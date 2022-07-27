using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementInterface
{
    class ConsoleListControl
    {
        public static void List(string[] headers, IListable[] items)
        {
            int[] columnWidths = DisplayHeaders(headers);
           
            for (int count = 0; count < items.Length; count++)
            {
                //string?[] values = items[count].ColumnValues;
                string[] values = items[count].ColumnValues;
                DisplayItemRow(columnWidths, values);

            }

        }


        /// <summary>Displays the column headers</summary>
        /// <returns>Returns an array of column widths</returns>
        private static int[] DisplayHeaders(string[] headers)
        {
            #region EXCLUDE
            var columnWidths = new int[headers.Length];
            for (int index = 0; index < headers.Length; index++)
            {
                Console.Write(headers[index]);
                columnWidths[index] = headers[index].Length;
            }
            Console.WriteLine();
            return columnWidths;
            #endregion EXCLUDE
        }

        private static void DisplayItemRow(int[] columnWidths, string[] values)
        {
            for (int index = 0; index < values.Length; index++)
            {
                string itemToPrint = (values[index] ?? "").PadRight(columnWidths[index], ' ');
                Console.Write(itemToPrint);
            }
            Console.WriteLine();
        }
    }
}
