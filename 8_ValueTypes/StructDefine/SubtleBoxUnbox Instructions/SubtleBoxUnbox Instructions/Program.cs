using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SubtleBoxUnbox_Instructions
{
    class DisplayFibonacci
    {
        static void Main()
        {
            int totalCount;
            ArrayList list = new ArrayList();

            Console.Write("Enter Number between 2 and 1000");
            totalCount = int.Parse (Console.ReadLine());

            list.Add((double)0);
            list.Add((double)1);

            for (int count = 2; count < totalCount; count++)
            {

                list.Add((double)list[count - 1] + (double)list[count - 2]);

            }
            foreach (double count in list)
            {

                Console.Write("{0}, ", count );
            }
            Console.ReadKey ();
        }
    }
}
