using System;
using System.Collections.Generic;
using HydraulicCalculator.Formulas;

namespace HydraulicCalculator
{
    public class Program
    {
        static List<IFormulaProvider> FormulaProvider = new List<IFormulaProvider>()
        {
            
        };

        static void DoAction(int userReaction)
        {
            var provider = FormulaProvider[userReaction - 1];
            provider.Execute();
        }
        static void ShowFunction()
        {
            //Console.WriteLine(
            //    "------------------------------- \n" +
            //    " The program has a functional : \n\n" +
            //    " 1. Add post ; \n" +
            //    " 2. Delete post ; \n" +
            //    " 3. Show all posts ; \n" +
            //    " 4. Check note ; \n" +
            //    " 5. Exit ; \n\n" +
            //    " Please enter the number :");

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