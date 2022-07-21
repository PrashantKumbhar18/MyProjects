using Markdig.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;

namespace AbstractMembers
{
    public class Program
    {
        public static void Main()
        {
            PdaItem[] pda = new PdaItem[3];

            Contact contact = new Contact("Sherlock Holmes");
            contact.Address = "221B Baker Street, London, England";
            pda[0] = contact;


            Appointment appointment = new Appointment("Soccer tournament");
            appointment.StartDateTime = new DateTime(2008, 7, 18);
            appointment.EndDateTime = new DateTime(2008, 7, 19);
            appointment.Location = "Estadio da Machava";
            pda[1] = appointment;

            contact = new Contact("Hercule Poirot");
            contact.Address = "Apt 56B, Whitehaven Mansions, Sandhurst Sq, London";
            pda[2] = contact;

            List(pda);


        }

        public static void List(PdaItem[] items)
        {
            foreach (PdaItem item in items)
            {
                Console.WriteLine("___________________");
                Console.WriteLine(item.GetSummary());
                

            }
            Console.ReadKey();

        }

    }
}
