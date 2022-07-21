using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;


namespace AbstractMembers
{
    public class Appointment : PdaItem
    {
        public Appointment(string name) : base(name)
        {
            Name = name;
        }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Location { get; set; }

        public override string GetSummary()
        {
            return $"Subject: {Name + NewLine}"
                + $"Start: {StartDateTime + NewLine}" +
                $"End: {EndDateTime + NewLine}" +
                $"Location: {Location}";


            throw new NotImplementedException();
        }
    }
}
