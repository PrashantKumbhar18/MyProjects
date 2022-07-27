using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningInterface
{
    internal interface IListable
    {
        //Return the value of each column in the row.
        string[] ColumnValues
        {
            get;
        }
    }
}
