using org.mariuszgromada.math.mxparser;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContingencyTableAnalysis
{
    static class Calculations
    {
        public static IDictionary<string, List<double>> GetCalculations(List<string> parametersNames, double[] userArguments)
        {
            Dictionary<string, List<double>> calculations = new Dictionary<string, List<double>>();
            /*
            double a = userArguments[0];
            double b = userArguments[1];
            double c = userArguments[2];
            double d = userArguments[3];
            double ARe = a * 100 / (a + b);
            double[] Za = { 0.1584 ,  0.3249,  0.5095 , 0.7265 , 1.0000 , 1.3764  ,1.9626 , 3.0777 , 6.3138 , 12.7062, 31.8205, 63.657  ,127.32 , 318.31 , 636.62 };

            foreach (var z in Za)
            {
                //double res1 = Math.Sqrt((a * 100 / (a + c) * c * 100 / (a + c)) / (a + c)) * z;
                //double res2 = Math.Sqrt((b * 100 / (b + d) * d * 100 / (b + d)) / (b + d)) * z;
                double res1 = z * Math.Sqrt((ARe*(1-ARe/100)/100 )*100/(a+b));
                Console.WriteLine(z+"-----------"+res1);
            }
            */

            foreach (var parameterName in parametersNames)
            {
                if (parameterName.Equals("Доверительный интервал индекса потенциального вреда")) // todo
                    continue;

                List<double> parameterResults = new List<double>();

                

                var parameterInfo = DBHelper.GetParameterInfo(parameterName); // Arguments, Expression 


                var argumentString = parameterInfo.Item1;
                var arguments = getArguments(argumentString, userArguments);
                var functions = parameterInfo.Item2.Split('|');// на случай, если параметр имеет 2 выражения

                Console.WriteLine("---------------------");
                Console.WriteLine("Func = " + functions[0] + "       args = " + argumentString);

                foreach (var function in functions) 
                {
                    string functionString = "f(" + argumentString + ") = " + function;
                    double result = new Function(functionString).calculate(arguments.ToArray());

                    parameterResults.Add(Math.Round(result,3));
                }

                

                calculations.Add(parameterName, parameterResults);
            }
            /* todo
            if(calculations.Keys.Contains("NNH (ЧПЭН) для исследований по типу «случай-контроль»"))
            {

                if (getArguments("OR",userArguments)[0].getArgumentValue() > 1)
                {
                    calculations.First(e => e.Key.Equals("")).Value.Remove(0);
                }
                else
                {
                    calculations.First(e => e.Key.Equals("")).Value.Remove(1);
                }
            }*/

            return calculations;
        }
        
        public static double GetCalculation(string parameterName, double[] userArguments)
        {
            
            var parameterInfo = DBHelper.GetParameterInfo(parameterName); // Arguments, Expression 

            var argumentString = parameterInfo.Item1;
            var arguments = getArguments(argumentString, userArguments);
            var function = parameterInfo.Item2;

            string functionString = "f(" + argumentString + ") = " + function;

            
            double result = new Function(functionString).calculate(arguments.ToArray());

            return result;
        }
        
        public static List<Argument> getArguments(string argumentsString, double[] userArguments)
        {
            var argumentList = new List<Argument>();

            double a = userArguments[0];
            double b = userArguments[1];
            double c = userArguments[2];
            double d = userArguments[3];
            

            foreach (var arg in argumentsString.Split(','))
            {
                Argument argument = null;
                switch (arg)
                {
                    case "a":
                        argument = new Argument("a", a);
                        break;
                    case "b":
                        argument = new Argument("b", b);
                        break;
                    case "c":
                        argument = new Argument("c", c);
                        break;
                    case "d":
                        argument = new Argument("d", d);
                        break;
                    case "Za":
                        argument = new Argument("Za", 12.7062);
                        break;
                    
                    default:
                        argument = new Argument(arg, GetCalculation(arg,userArguments));
                        break;
                }
                argumentList.Add(argument);
            }

            return argumentList;
        }

    }
}
