using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivingOneClassfromAnother
{

    public class PdaItem : Object
    {
        public string Name { get; set; }

        // private string Name { get; set; } gives an error : Not accessible due to its protection level
        public DateTime LastUpdated { get; set; }

        protected Guid ObjectKey { get; set; }  
    }

    public class Appointment : PdaItem
    {

    }

    //Define the Contact class as inheriting the PdaItem class 
    public class Contact : PdaItem
    {
        public string Address { get; set; } 
        public string Phone { get; set; }   

    }

    public class Customer : Contact
    {

    }
    public class Program
    {
        static void Main()
        {
            Contact contact = new Contact();
            contact.Name = "Indigo Montaya";

            //Derived Type can be implicitly converted to base Type
            PdaItem item = contact;

            // Base Type must be cast explicitly to derived types
            contact = (Contact)item;

            contact.ObjectKey = Guid.NewGuid();

            Console.WriteLine (contact.Name, item );
            Console.ReadKey();  
        }

    }
}


