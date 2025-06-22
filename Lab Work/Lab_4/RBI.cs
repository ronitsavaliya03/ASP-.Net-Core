using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class RBI
    {
        public virtual void calculateInterest()
        {
            Console.WriteLine("Calculation Interest in RBI");
        }
    }

    class HDFC : RBI
    {
        public override void calculateInterest()
        {
            Console.WriteLine("Calculation Interest in HDFC");
        }
    }

    class SBI : RBI
    {
        public override void calculateInterest()
        {
            Console.WriteLine("Calculation Interest in SBI");
        }
    }

    class ICICI : RBI
    {
        public override void calculateInterest()
        {
            Console.WriteLine("Calculation Interest in ICICI");
        }
    }
}
