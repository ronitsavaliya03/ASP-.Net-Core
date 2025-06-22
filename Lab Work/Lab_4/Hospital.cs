using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Hospital
    {
        public virtual void HospitalDetails()
        {
            Console.WriteLine("Hospital");
        }
    }

    class Apollo : Hospital 
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Apollo Hospital");
        }
    }
    class Wockhardt : Hospital {
        public override void HospitalDetails()
        {
            Console.WriteLine("Wockhardt Hospital");
        }
    }
    class Gokul_Superspeciality : Hospital {
        public override void HospitalDetails()
        {
            Console.WriteLine("Gokul_Superspeciality Hospital");
        }
    }
}
