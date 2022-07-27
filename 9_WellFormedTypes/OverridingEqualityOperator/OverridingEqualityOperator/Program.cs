using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingEqualityOperator
{

  
    class Program
    {
          public sealed class ProductSerialNumbers
    {
        //....
        public ProductSerialNumbers(string v1, int v2, int v3)
        {
        }
    }
        static void Main()
        {
            ProductSerialNumbers SerialNumber1 = new ProductSerialNumbers("PV", 1000, 09187234);
            ProductSerialNumbers SerialNumber2 =  SerialNumber1;
            ProductSerialNumbers SerialNumber3 = new ProductSerialNumbers("PV", 1000, 09187234);

            //These serial number are the same object identity.

            if (ProductSerialNumbers.ReferenceEquals(SerialNumber1, SerialNumber2))
            {
                throw new Exception("SerialNumber1 does NOT" + "reference equal serialNumber2");
            }
            else if (SerialNumber1.Equals (SerialNumber2))
            {
                throw new Exception("serialNumber1 does not equal serialNumber2");
            }
            else
            {
                Console.WriteLine("serialNumber1 reference equals serialNumber2");
                Console.WriteLine("serialNumber1 equals serialNumber2");
            }

            //These serial numbers are NOT the same object identity.
            if(ProductSerialNumbers.ReferenceEquals(SerialNumber1, SerialNumber3))
            {
                throw new Exception("serialNumber1 DOES reference" + "equal serialNumber3");
            }

            //But they are equal (assuming Equals is overLoaded)

            else if (!SerialNumber1.Equals (SerialNumber3)   || SerialNumber1 != SerialNumber3)
            {
                throw new Exception("serialNumber1 does not equal serialNumber3");
            }
            Console.WriteLine("serialNumber1 equals serialNumber3");
        }
    }
}
