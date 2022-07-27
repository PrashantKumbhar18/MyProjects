using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDefine
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    struct Angle
    {
        public Angle(int degrees, int minutes, int seconds)
        {
            Degrees = degrees;
            Minutes = minutes;
            Seconds = seconds;
        }

        public int Degrees { get { return _Degrees; } }
        readonly private int _Degrees;
        public int Minutes { get { return _Minutes; } }
        readonly private int _Minutes;
        public int Seconds { get { return _Seconds; } }
        readonly private int _Seconds;

        public Angle Move(int degrees, int minutes, int seconds)
        {
            return new Angle(
                    Degrees + degrees,
                    Minutes + minutes,
                    Seconds + seconds);

        }
    }

    class coordinates
        {
            public Angle Longitude { get; set; }
        public Angle Latitude { get; set; }

        }

}
