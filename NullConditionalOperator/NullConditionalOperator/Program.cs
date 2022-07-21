using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullConditionalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if (args?.Length == 0)
            {
                System.Console.WriteLine(
                    "ERROR: File Missing."
                    + "USE: \n\tfind.exe file<filename>");

                System.Console.ReadKey();
            }
            else
            {
                if (args[0]?.ToLower().StartsWith("file:") ?? false)
                {
                    string fileName = args[0]?.Remove(0,5);
                    System.Console.WriteLine(fileName);
                    System.Console.ReadKey();

                }
            }
        }
    }
}
