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
                        argument = new Argument("Za", 12.7062);
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
