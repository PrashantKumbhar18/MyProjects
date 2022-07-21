using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    class Program
    {
        static void Main()
        {
            // Specifying Literal Values
            System.Console.WriteLine(42);
            System.Console.WriteLine(1.618034);

            // Specifying a Literal double
            System.Console.WriteLine(1.618033988749895);  // output only 1.61803398874989

            // Specifying a Literal decimal
            System.Console.WriteLine(1.618033988749895M);

            // Exponential notation
            System.Console.WriteLine(6.023E23F);

            // Display the value 42 using a hexadecimal literal.
            System.Console.WriteLine(0x002A);

            // Example of a Hexadecimal Format Specifie     ***Displays "0x2A"***
            System.Console.WriteLine(($"0x{42:X}"));

            //Formatting Using the Round-Trip Format Specifier
            const double number = 1.618033988749895;
            double result;
            string text;
            
            text = $"{number}";
            result = double.Parse(text);
            System.Console.WriteLine($"\n{result == number}: result == number");
            
            text = string.Format("{0:R}", number);
            result = double.Parse(text);
            System.Console.WriteLine($"{result == number}: result == number");

            //Displaying Single Quote
            System.Console.WriteLine("\n" + "Escape Characters" + "\n");
            System.Console.WriteLine('\'');
            System.Console.WriteLine('\"');
            System.Console.WriteLine('\\');
            System.Console.WriteLine('\0');


            //Using Unicode Encoding to Display a Smiley Face
            System.Console.Write('\u003A');
            System.Console.WriteLine('\u0029');
            
            System.Console.WriteLine("\n");

            //Using the \n Character to Insert a Newline
            System.Console.Write(
            "\"Truly, you have a dizzying intellect.\"");
            System.Console.Write("\n\"Wait 'til I get going!\"\n");




            System.Console.ReadKey();
        }
    }
}
