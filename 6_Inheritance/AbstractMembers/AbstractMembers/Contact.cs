using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;

namespace AbstractMembers
{
    public class Contact : PdaItem
    {
        public Contact(string name) : base(name)
        {
        }

        public override string Name
        {

            get
            {
                return $"{FirstName}{LastName}";
            }
            set
            {
                string[] names = value.Split(' ');

                FirstName = names[0];
                LastName = names[1];
            }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
       
        public override string GetSummary()
        {
            return $"FirstName: {FirstName + NewLine}"
                    + $"LastName : {LastName + NewLine}"
                            + $"Address : {Address + NewLine}";

            throw new NotImplementedException();
        }

    }

    
}

