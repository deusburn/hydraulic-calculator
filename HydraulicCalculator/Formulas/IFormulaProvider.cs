using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydraulicCalculator.Formulas
{
    interface IFormulaProvider
    {
        void Execute();
        string FormulaName { get; }
    }
}
