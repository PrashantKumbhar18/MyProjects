using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingThe__and__Operators
{
    class Program
    {
        public sealed class ProductSerialNumber
        {
            public static bool operator == (ProductSerialNumber leftHandSide, ProductSerialNumber rightHandSide)
            { 
                if(ReferenceEquals(leftHandSide , null))
                {
                    return ReferenceEquals(rightHandSide, null);
                }
                return (leftHandSide.Equals( null));
            }
            public static bool operator != (ProductSerialNumber leftHandSide, ProductSerialNumber rightHandSide)
            {
                return !(leftHandSide == rightHandSide);
            }

        }
        static void Main()
        {
        }
    }
}
