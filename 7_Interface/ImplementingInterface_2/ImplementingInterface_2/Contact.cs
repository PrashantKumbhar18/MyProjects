using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;

namespace ImplementingInterface_2
{
    public class Contact : PdaItem, IListable, IComparable

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

        #region IComparable Members
        ///<Summary></Summary>
        ///<param name="obj"></param>
        ///<returns>
        ///Less than zero :         This instance is less than obj.
        ///Zero:                    This instance is equal to obj.
        ///Greater than Zero :      This instance is greater than obj.
        /// </returns>
        
        public int CompareTo (object obj)
        {

            int result;
            Contact contact = obj as Contact;

            if (obj == null)
            {
                result = 1;
            }
            else if (obj.GetType() != typeof(Contact))
            {
                throw new ArgumentException($"The Parameter is not a of Type{nameof(Contact)}", nameof(obj));
            }
            else if (Contact.ReferenceEquals(this, obj))
            {
                result = 0;
            }
            else
            {
                result = LastName.CompareTo(contact.LastName);
                if(result == 0)
                {
                    result = FirstName.CompareTo(contact.FirstName);
                }
            }
            return result;
        }
        #endregion

        #region IListable Members
        string[] Ilistable.ColumnValues
        {

            get
            {
                return new string[]
                    FirstName,
                    LastName,
                    Phone,
                    Address
            };
        }
    }
    #endregion
}

