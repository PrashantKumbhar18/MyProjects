using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingGetHashCode
{
    internal class Program
    {
        public struct coordinate
        {
            public coordinate (Longitude longitude, Latitude latitude)
            {
                Longitude = longitude;
                Latitude = latitude;
            }

            public Longitude Longitude { get; }
            public Latitude Latitude { get; }

            public override int GetHashCode()
            {
                int hashCode = Longitude.GetHashCode();
                if (Longitude.GetHashCode() != Latitude.GetHashCode())
                {
                    hashCode ^= Latitude.GetHashCode();
                }                
                return hashCode;
            }
        }
        
      

        static void Main()
        {
        }
    }
    public struct Longitude { };
    public struct Latitude { };

}
