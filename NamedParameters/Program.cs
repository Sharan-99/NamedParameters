using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameters
{
    class Program
    {
        private static void GetCohortDetails(string cohortName,int count,string track,string mode,string currentModule)
        {
            Console.WriteLine("It is {0} with {1} GenCs undergoing training for {2} thru {3}. The current module of training is {4}",
                              cohortName, count, track, mode, currentModule);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //Normal Method Call
            GetCohortDetails("ADM21DF015", 21, "DotNet", "OBL", "MVC");

            //Method call with named parameters in the order
            GetCohortDetails(cohortName: "ADM21DF015",count:21,track:"DotNet",mode:"OBL",currentModule:"MVC");

            //Method call with named parameters not in the order
            GetCohortDetails(mode: "OBL", currentModule: "MVC",count: 21,cohortName: "ADM21DF015", track: "DotNet");

            //Method call with incorrect order and without named paramaters
            GetCohortDetails("DotNet", 21, "OBL", "MVC", "ADM21DF015");

            Console.ReadKey();
        }
    }
}
