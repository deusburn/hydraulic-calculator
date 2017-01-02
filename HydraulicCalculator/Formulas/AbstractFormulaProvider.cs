namespace HydraulicCalculator.Formulas
{
    abstract class AbstractFormulaProvider : IFormulaProvider
    {
        public void Execute()
        {
            GetInputData();
            Calculate();
            WriteResult();
        }

        protected abstract void WriteResult();

        protected abstract void Calculate();

        protected abstract void GetInputData();

        public abstract string FormulaName { get; }
    }
}
