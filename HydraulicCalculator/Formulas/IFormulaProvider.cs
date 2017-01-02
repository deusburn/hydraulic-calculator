namespace HydraulicCalculator.Formulas
{
    interface IFormulaProvider
    {
        void Execute();
        string FormulaName { get; }
    }
}
