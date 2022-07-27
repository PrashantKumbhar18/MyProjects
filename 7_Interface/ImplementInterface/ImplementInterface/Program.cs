using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementInterface
{
    class Program
    {
        public static void Main()
        {
            Contact[] contacts = new Contact[6];

            contacts[0] = new Contact("Dick", "Traci", "123 Main St., Spokane, WA, 99037", "123-123-1234");
            contacts[1] = new Contact("Andrew", "Littman", "1417 Palmary St., Dallas, TX, 55555", "555-123-4567");
            contacts[2] = new Contact("Mary", "Hartfelt", "1520 Thunder Way, Elizabethton, PA 44444", "444-123-4567");
            contacts[3] = new Contact("John", "Lindherst", "1 Aerial Way Dr., Monteray, NH 88888", "222-987-6543");
            contacts[4] = new Contact("Pat", "Wilson", "565 Irving Dr., Parksdale, FL 22222", "123 - 456 - 7890");
            contacts[5] = new Contact("Jane", "Doe", "123 Main St., Aurora, IL 66666", "333-345-6789");

            //Classes are cast implicitly to
            //their supported interfaces.
            ConsoleListControl.List(Contact.Headers, contacts);
            Console.WriteLine();

            Publication[] publications = new Publication[3]
            {
                new Publication("Celebration of Disciplie", "Richard Foster",1978),
                new Publication("Orthodoxy", "G.K. Chesterton",1908),
                new Publication("The Hitchhiker's Guide to the Galaxy", "Douglas Adams",1979),

            };
            ConsoleListControl.List(Publication.Headers, publications);
            Console.ReadKey();
        }
        
    }
}
