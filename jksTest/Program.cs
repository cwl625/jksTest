using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dllTestProj;

namespace jksTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TestClass testClass = new TestClass();
            //
            //
            //

            Debug.WriteLine("Hello");
            Console.WriteLine("Hello@@@@@@@@@@@");
            string str = testClass.AddString("Hello");

            Console.WriteLine(str);



        }
    }
}
