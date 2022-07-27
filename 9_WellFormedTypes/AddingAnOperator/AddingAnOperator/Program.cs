using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingAnOperator
{
    class Program
    {
        struct Arc
        {
            public Arc(Longitude longitudeDifference, Latitude latitudeDifference)
            {
                LongitudeDifference = longitudeDifference;
                LatitudeDifference = latitudeDifference;
            }
            public Longitude LongitudeDifference { get; }
            public Latitude LatitudeDifference { get; }
        }
        public struct Longitude { }
        public struct Latitude
        {
            public Latitude(object value)
            {
            }
        }


        struct Coordinate
        {
            // ...
            public static Coordinate operator +(
            Coordinate source, Arc arc)
            {
                Coordinate result = new Coordinate(new Longitude(source.Longitude + arc.LongitudeDifference),
                    new Latitude(source.Latitude + arc.LatitudeDifference));
                return result;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
