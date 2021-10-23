using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi201.a211023
{
    public class CCalculator
    {
        public double Arg2;
        public double Arg1;
        public EOperation CurrentOperation;

        #region constructors
        public CCalculator ()
        {
        }

        public CCalculator (
            double arg1, 
            double arg2, 
            EOperation currentOperation)
        {
            Arg2 = arg2;
            Arg1 = arg1;
            CurrentOperation = currentOperation;
        }
        #endregion

        public double Calculate()
        {
            return Calculate(Arg1, Arg2, CurrentOperation);
        }

        public double Calculate(double dArg1, double dArg2, EOperation enOper)
        {
            double result = dArg2;
            switch (enOper)
            {
                case EOperation.Plus:
                    result = dArg2 + dArg1;
                    Arg1 = result;
                    break;
                case EOperation.Minus:
                    result = dArg1 - dArg2;
                    Arg1 = result;
                    break;
            }
            return result;
        }
    }
}
