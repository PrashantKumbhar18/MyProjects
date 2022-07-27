using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The using directives allow you to drop the namespace
using static System.Console;

namespace staticDirective
{
    internal class HeyYou
    {
        static void Main()
        {
            string firstName;
            string lastName;

            WriteLine("Hey you!");


            Write("Enter your First Name?");
            firstName = ReadLine(); 
            WriteLine("Enter Your Last Name?");
            lastName = ReadLine();

            WriteLine(
                $"Your full name is {firstName} {lastName}.");
            
            
            ReadKey();


        }
    }
}
