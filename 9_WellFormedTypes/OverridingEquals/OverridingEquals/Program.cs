using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingEquals
{
    class Program
    {

        public struct Longitude { }
        public struct Latitude { }

        public struct Coordinate 
        {
            public Coordinate( Longitude longitude, Latitude latitude)
            {
                Longitude = longitude;
                Latitude = latitude;
            }

            public Longitude Longitude { get;  }    
            public Latitude Latitude { get; }
            
            public override bool Equals(Object obj)
            {
                //STEP1: Check for null.
                if (obj == null)
                {
                    return false;
                }

                if (this.GetType() != obj.GetType())
                {
                    return false;
                }

                return Equals((Coordinate)obj);
            }
            public bool Equals(Coordinate obj)
            {
                
                 return ((Longitude.Equals(obj.Longitude)) && (Latitude.Equals(obj.Latitude)));
            }
            public override int GetHashCode()
            {
                int hashCode = Longitude.GetHashCode();
                hashCode ^= Latitude.GetHashCode(); // Xor (eXclusive OR)
                return hashCode;
            }
        }
        static void Main()
        {
            Console.ReadKey();
        }
    }
}
