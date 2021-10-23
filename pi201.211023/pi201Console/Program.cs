using pi201.a211023;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi201Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CCalculator pC = new CCalculator();
            
            Console.WriteLine("arg1");
            string sArg1 = Console.ReadLine();
            double dArg1 = Double.Parse(sArg1);
            while (true)
            {
                Console.WriteLine("oper (1 = +, 2 = -)");
                string sOper = Console.ReadLine();
                if (sOper == "")
                {
                    break;
                }
                Console.WriteLine("arg2");
                string sArg2 = Console.ReadLine();
                double dArg2 = Double.Parse(sArg2);

                EOperation enOper = sOper == "1" ? EOperation.Plus : EOperation.Minus;

                // 
                pC.Arg1 = dArg1;
                pC.Arg2 = dArg2;
                pC.CurrentOperation = enOper;
                double dRes1 = pC.Calculate();
                dArg1 = dRes1;
                // или
                double dRes2 = pC.Calculate(dArg1, dArg2, enOper);
                dArg1 = dRes2;

                Console.WriteLine(dRes1);
            }
        }
    }
}
