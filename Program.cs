using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceTreeTest
{
    public class Program
    {
        private static string versionDate = "14/04/2016";
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo");
            Console.WriteLine("Primer commit");
            Console.WriteLine("Branch HAnsy");
            Problem2 prob = new Problem2();
            prob.GetFuncionPrincipal();
            prob.GetBranchMaster();
            prob.GetBranchHansy();

            prob.GetPrueba();
            Console.WriteLine(versionDate);
            Console.ReadKey();
        }
    }
}
