using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMembers
{
    public abstract class PdaItem
    {
        public PdaItem(string name)
        {
            Name = name;
        }

        public virtual string Name { get; set; }
        public abstract string GetSummary();
    }
}
