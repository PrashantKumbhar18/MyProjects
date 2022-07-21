using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeyYou
{
    class HeyYou
    {
        static void Main()
        {
            //Getting Input from the Console
            string firstName;           // Variable for storing the first name             //--Single Line Comments--
            string lastName;            // Variable for storing the last name

            System.Console.WriteLine("Hey You!");   

            System.Console.Write(       /* No new line */                                  /*--delimited comment inside statement--*/
                "Enter Your First Name: ");
            firstName = System.Console.ReadLine();

            System.Console.Write("Enter Your last Name: ");
            lastName = System.Console.ReadLine();

            // Formatting Using String Interpolation
            System.Console.WriteLine(
                    $"Your full name is {firstName} {lastName}.");

            /* Display a greeting to the console                                            --delimited comment--
            using composite formatting. */


            //Formatting Using System.Console.WriteLine()’s Composite Formatting
            System.Console.WriteLine(
                    "Your full name is {0} {1}.", firstName, lastName);

            //Swapping the Indexed Placeholders and Corresponding Variables
            System.Console.WriteLine("Your full name is {1}, {0}", firstName, lastName);

            Console.ReadKey();
        }
    }
}
