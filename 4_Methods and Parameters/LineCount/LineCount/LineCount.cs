using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineCount
{
    class LineCount
    {
        
        static void Main()
        {
            int lineCount;
            string files;
            DisplayHelpText();
            files = Getfiles();
            lineCount = CountLines(files);
            DisplayLineCount(lineCount);
        }
    }
}
