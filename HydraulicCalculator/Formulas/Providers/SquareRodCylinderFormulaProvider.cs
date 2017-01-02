using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydraulicCalculator.Formulas.Providers
{
    class SquareRodCylinderFormulaProvider : AbstractFormulaProvider
    {
        private double DiameterPiston { get; set; }
        private double DiameterRod { get; set; }

        public double SquarePistonRodCylinder { get; set; }

        protected override void WriteResult()
        {
            Console.WriteLine("{0} = {1:F5}", "Діаметр поршня гідроциліндра", SquarePistonRodCylinder);
        }

        protected override void Calculate()
        {
            SquarePistonRodCylinder = (Math.Pow(DiameterPiston, 2) - Math.Pow(DiameterRod, 2)) / 4;
        }

        protected override void GetInputData()
        {
            Console.WriteLine("Введіть діаметр поршня циліндра");
            DiameterPiston = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть діаметр штока циліндра");
            DiameterRod = double.Parse(Console.ReadLine());
        }

        public override string FormulaName
        {
            get { return "Розрахунок площі штокової порожнини циліндра"; }
        }
    }
}
