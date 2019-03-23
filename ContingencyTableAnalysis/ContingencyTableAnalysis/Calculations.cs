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


            foreach (var parameterName in parametersNames)
            {
                List<double> parameterResults = new List<double>();

                var parameterInfo = DBHelper.GetParameterInfo(parameterName); // Arguments, Expression 

                var argumentString = parameterInfo.Item1;
                var arguments = getArguments(argumentString, userArguments);
                var functions = parameterInfo.Item2.Split('|');// на случай, если параметр имеет 2 выражения

                foreach (var function in functions) 
                {
                    string functionString = "f(" + argumentString + ") = " + function;
                    double result = new Function(functionString).calculate(arguments.ToArray());

                    parameterResults.Add(result);
                }

                

                calculations.Add(parameterName, parameterResults);
            }

            return calculations;
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
                    case "aOj":
                        argument = new Argument("aOj", ((a + c) * (a + b)) / (a + b + c + d));
                        break;
                    case "bOj":
                        argument = new Argument("bOj", ((b + d) * (a + b)) / (a + b + c + d));
                        break;
                    case "cOj":
                        argument = new Argument("cOj", ((a + c) * (c + d)) / (a + b + c + d));
                        break;
                    case "dOj":
                        argument = new Argument("dOj", ((b + d) * (c + d)) / (a + b + c + d));
                        break;
                    case "xi":
                        argument = new Argument("xi", getXi(a, b, c, d));
                        break;
                    case "OR":
                        argument = new Argument("OR", a * d / b * c);
                        break;
                    case "Za":
                        //todo argument = new Argument();
                        break;
                    case "RR":
                        argument = new Argument("RR", a * (c + d) / c * (a + b));
                        break;
                    case "ARe":
                        argument = new Argument("ARe", a / (a + b) * 100);
                        break;
                    case "ARn":
                        argument = new Argument("ARn", c / (c + d) * 100);
                        break;
                    case "AtR":
                        argument = new Argument("ARn", (a / (a + b) - c / (c + d)) * 100); // todo ???
                        break;
                    case "Se":
                        argument = new Argument("Se", a / (a + c) * 100);
                        break;
                    case "Sp":
                        argument = new Argument("Sp", d / (b + d) * 100);
                        break;
                    case "Ac":
                        argument = new Argument("Ac", (a + d) / (a + b + c + d) * 100);
                        break;
                    case "+PV":
                        argument = new Argument("+PV", a / a + b * 100);
                        break;
                    case "-PV":
                        argument = new Argument("-PV", c / c + d * 100);
                        break;
                    case "LR+":
                        argument = new Argument("LR+", (a / (a + c)) / (b / (b + d)));
                        break;
                    case "LR-":
                        argument = new Argument("LR-", (c / (a + c)) / (d / (b + d)));
                        break;
                    case "ARR":
                        argument = new Argument("ARR", (c / (a + c) - d / (b + d)) * 100);
                        break;



                    default:
                        break;
                }
                argumentList.Add(argument);
            }

            return argumentList;
        }
        private static double getXi(double a, double b, double c, double d)
        {
            double aOj = ((a + c) * (a + b)) / (a + b + c + d);
            double bOj = ((b + d) * (a + b)) / (a + b + c + d);
            double cOj = ((a + c) * (c + d)) / (a + b + c + d);
            double dOj = ((b + d) * (c + d)) / (a + b + c + d);

            double xi = Math.Pow(a - aOj, 2) / aOj + Math.Pow(b - bOj, 2) / bOj + Math.Pow(c - cOj, 2) / cOj + Math.Pow(d - dOj, 2) / dOj;
            return xi;
        }

    }
}
