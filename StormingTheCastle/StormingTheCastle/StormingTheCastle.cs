using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StormingTheCastle
{
    class StormingTheCastle
    {
        static void Main()
        {

            //Changing the Value of a Variable
            string valerie;
            string miracleMax = "Have fun storming the castle!";
            string requirements;

            valerie = "Think it will work?";

            System.Console.WriteLine(valerie);
            System.Console.WriteLine(miracleMax);

            // Assignment Returning a Value That Can Be Assigned Again
            requirements = miracleMax = "It would take a miracle.";
            System.Console.WriteLine(requirements);

            Console.ReadKey();

        }
    }
}
