using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydraulicCalculator.Formulas.Providers
{
    class CostsThrottleFormulaProvider : AbstractFormulaProvider
    {
        private double SquareРole { get; set; }
        private double FactorCosts { get; set; }
        private double Density { get; set; }
        private double PressureDrop { get; set; }

        public double CostsThrottle { get; set; }

        protected override void WriteResult()
        {
            Console.WriteLine("{0} = {1:F5}", "Витрата через дрочель становить", CostsThrottle);
        }

        protected override void Calculate()
        {
            CostsThrottle = SquareРole * FactorCosts * Math.Sqrt(2 * PressureDrop/ Density);
        }

        protected override void GetInputData()
        {
            Console.WriteLine("Введіть площу отвору");
            SquareРole = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть коефіцієнт витрати");
            FactorCosts = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть густину рідини");
            Density = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть перепад тиску");
            PressureDrop = double.Parse(Console.ReadLine());
        }

        public override string FormulaName
        {
            get { return "Розрахунок витрати дроселя"; }
        }
    }
}
