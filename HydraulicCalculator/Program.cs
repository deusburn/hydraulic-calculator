using System;
using System.Collections.Generic;
using System.Text;
using HydraulicCalculator.Formulas;
using HydraulicCalculator.Formulas.Providers;

namespace HydraulicCalculator
{
    public class Program
    {
        static List<IFormulaProvider> FormulaProvider = new List<IFormulaProvider>()
        {
            new CylinderDiameterFormulaProvider(),
            new SquarePistonCylinderFormulaProvider(),
            new SquareRodCylinderFormulaProvider()
        };

        static void DoAction(int userReaction)
        {
            var provider = FormulaProvider[userReaction - 1];
            provider.Execute();
        }
        static void ShowFunction()
        {
            string begin = "------------------------------- \n" +
                           " The program has a functional : \n\n";
            string end = " Please enter the number :";
            string centralPart = "";

            for (int i = 0; i < FormulaProvider.Count; i++)
            {
                centralPart += string.Format("{0}. {1} ; \n", i + 1, FormulaProvider[i].FormulaName);
            }
            centralPart += string.Format("{0}. {1} ; \n", FormulaProvider.Count + 1, "Exit");

            var result = begin + centralPart + end;
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int userReaction = 0;

            do
            {
                try
                {
                    ShowFunction();

                    userReaction = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    DoAction(userReaction);
                }
                catch (Exception)
                {
                    Console.WriteLine();
                    Console.WriteLine(" You entered not correct number !!! ");
                    Console.WriteLine();
                }
            } while (userReaction != GetExitCodeNumber());
        }

        private static int GetExitCodeNumber()
        {
            return FormulaProvider.Count + 1;
        }
    }
}