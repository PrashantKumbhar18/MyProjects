using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;

namespace ImplementInterface
{
    public class Contact : PdaItem, IListable

    {
        public Contact(string firstName, string lastName, string address, string phone) : base(null)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Phone = phone;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public string[] ColumnValues
        { 
            get
            {
                return new string[]
                {
                    FirstName,
                    LastName,
                    Address,
                    Phone
                 };
            }
        }
        public static string[] Headers
        {
            get
            {
                return new string[]
                {
                    "FirstName",
                    "LastName",
                    "Phone",
                    "Address"
                };
            }
        }

        //string IListable.ColumnValues => throw new NotImplementedException();
    }
}

