using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementInterface
{
    public class Publication : IListable
    {
        public Publication(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }
        public string Title { get; set; }   
        public string Author { get; set; }  
        public int Year { get; set; }

        public string[] ColumnValues
        { 
            get
            {
                return new string[]
                {
                    Title,
                    Author,
                    Year.ToString()
                };

            }
        }

        public static string[] Headers
        {
            get
            {
                return new string[]
                {
                    "Titel ",
                    "Autor",
                    "Year"
                };
            }
        }

        //string IListable.ColumnValues => throw new NotImplementedException();

        // public string ColumnValues => throw new NotImplementedException();
    }
}
