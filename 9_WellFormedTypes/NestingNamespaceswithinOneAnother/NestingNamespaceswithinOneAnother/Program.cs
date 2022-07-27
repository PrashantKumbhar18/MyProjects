using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestingNamespaceswithinOneAnother
{
    //Define the NameSpace AddisonWesley
    namespace AddisonWesley
    {
        //Define the NameSpace AddisonWesley.Michaelis
        namespace Michaelis
        {                   
            namespace EssencialCsharp       // Define the namespace AddisonWesley.Michaelis.EssentialCSharp
            {
                class Program               // Declare the class AddisonWesley.Michaelis.EssentialCSharp.Program
                {
                    static void Main()      
                    {
                        //....
                    }
                }
            }
        }
    }

    //Nesting Namespaces Using a Period to Separate Each Identifie

    // Define the namespace AddisonWesley.Michaelis.EssentialCSharp
    namespace AddisonWesley2.Michaelis2.EssencialCsharp
    {
        class Program2
        { 

        }
    }
    // End of AddisonWesley namespace declaration
}
