using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceTreeTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo");
            Console.WriteLine("Primer commit");
            Console.WriteLine("Branch HAnsy");
            Problem2 prob = new Problem2();
            prob.GetBranchMaster();
            prob.GetPrueba();
            Console.ReadKey();
        }
    }
}
