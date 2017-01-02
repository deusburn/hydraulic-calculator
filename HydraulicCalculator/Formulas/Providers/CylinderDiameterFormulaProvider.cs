using System;

namespace HydraulicCalculator.Formulas.Providers
{
    class CylinderDiameterFormulaProvider : AbstractFormulaProvider
    {
        private double HydraulicCylinderMaxPressure { get; set; }
        private double NominalOperatingPressure { get; set; }
        private double HydromechanicalEfficiency { get; set; }

        public double PistonCylinderDiameter { get; set; }

        protected override void WriteResult()
        {
            Console.WriteLine("{0} = {1:F3}", "Діаметр поршня гідроциліндра", PistonCylinderDiameter);
        }

        protected override void Calculate()
        {
            PistonCylinderDiameter = Math.Sqrt((4*HydraulicCylinderMaxPressure)/
                                         (Math.PI*NominalOperatingPressure*HydromechanicalEfficiency));
        }

        protected override void GetInputData()
        {
            Console.WriteLine("Введіть максимальний тиск гідроциліндра");
            HydraulicCylinderMaxPressure = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть номінальний робочий тиск");
            NominalOperatingPressure = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть гідромеханічний КПД");
            HydromechanicalEfficiency = double.Parse(Console.ReadLine());
        }

        public override string FormulaName
        {
            get { return "Розрахунок діаметра гідроциліндра"; }
        }
    }
}
