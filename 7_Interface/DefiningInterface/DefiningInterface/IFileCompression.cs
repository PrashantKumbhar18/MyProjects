using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningInterface
{
    internal interface IFileCompression
    {
        void Compress(string targetFileName, string[] fileList);
        void Uncompress(string compressedFileName, string ExpandDirectoryName);


    }
}
