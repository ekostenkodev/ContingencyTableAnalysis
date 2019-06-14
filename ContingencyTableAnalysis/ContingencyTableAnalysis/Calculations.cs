using org.mariuszgromada.math.mxparser;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContingencyTableAnalysis
{
    static class Calculations
    {

        public static IDictionary<string, List<double>> GetResults(List<string> parametersNames, double[] userArguments)
        {
            Dictionary<string, List<double>> calculations = new Dictionary<string, List<double>>();

            foreach (var parameterName in parametersNames)
            {
                if (parameterName.Equals("Доверительный интервал индекса потенциального вреда")) // todo уточнить у заказчика
                    continue;

                var parameterResults = GetCalculation(parameterName, userArguments);

                calculations.Add(parameterName, parameterResults);
            }

            correctCalculations(calculations, userArguments); // уточнение результатов(по тз)

            return calculations;
        }

        
        public static List<double> GetCalculation(string parameterName, double[] userArguments)
        {
            List<double> parameterResults = new List<double>();

            var parameterInfo = DBHelper.GetParameterInfo(parameterName); // Arguments, Expression 

            var argumentString = parameterInfo.Item1;
            var arguments = getArguments(argumentString, userArguments);
            string[] functions = parameterInfo.Item2.Split('|');// на случай, если параметр имеет 2 выражения

            foreach (var function in functions) 
            {
                string functionString = "f(" + argumentString + ") = " + function;
                double result = new Function(functionString).calculate(arguments.ToArray());

                parameterResults.Add(Math.Round(result,3));
            }

            return parameterResults;

        }

        private static void correctCalculations(Dictionary<string, List<double>> calculations, double[] userArguments)
        {
            string parameter = "NNH (ЧПЭН) для исследований по типу «случай-контроль»";
            if (calculations.Keys.Contains(parameter))
            {
                if (GetCalculation("OR", userArguments)[0] > 1)
                {
                    calculations.First(e => e.Key.Equals(parameter)).Value.RemoveAt(0);
                }
                else
                {
                    calculations.First(e => e.Key.Equals(parameter)).Value.RemoveAt(1);

                }
            }
        }

        private static double getZa()
        {
            double Za = 12.7062;// default
            double P = int.Parse(Properties.Resources.Setting1);
            double[] zaArray = { 0.1584,   0.3249,  0.5095  ,0.7265  ,1.0000  ,1.3764  ,1.9626  ,3.0777  ,6.3138  ,12.7062 ,31.8205 ,63.657  ,127.32  ,318.31  ,636.62 };
            double[] pArray = {0, 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 0.95, 0.98, 0.99, 0.995, 0.998, 0.999 ,1};

            for (int i = 0; i < pArray.Length-1; i++)
            {
                if(P> pArray[i] && P < pArray[i + 1])
                {
                    Za = zaArray[i];
                    break;
                }
            }
            return Za;
        }

        private static List<Argument> getArguments(string argumentsString, double[] userArguments)
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
                        argument = new Argument("Za", getZa());
                        break;
                    
                    default:
                        argument = new Argument(arg, GetCalculation(arg,userArguments)[0]);
                        break;
                }
                argumentList.Add(argument);
            }

            return argumentList;
        }

    }
}
