using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydraulicCalculator.Formulas.Providers
{
    class SquarePistonCylinderFormulaProvider : AbstractFormulaProvider
    {
        private double DiameterCylinder { get; set; }

        public double SquarePistonCavityCylinder { get; set; }

        protected override void WriteResult()
        {
            Console.WriteLine("{0} = {1:F5}", "Площа поршневої порожнини циліндра", SquarePistonCavityCylinder);
        }

        protected override void Calculate()
        {
            SquarePistonCavityCylinder = (Math.PI*Math.Pow(DiameterCylinder, 2)) / 4;
        }

        protected override void GetInputData()
        {
            Console.WriteLine("Введіть діаметр циліндра");
            DiameterCylinder = double.Parse(Console.ReadLine());
        }

        public override string FormulaName
        {
            get { return "Розрахунок площі поршневої порожнини циліндра"; }
        }
    }
}
