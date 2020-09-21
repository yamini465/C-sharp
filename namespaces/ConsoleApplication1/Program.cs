using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PATA=ProjectA.TeamA;
using PBTB = ProjectA.TeamB;
//using ProjectA.TeamB;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            PATA.ClassA.Print();
            PBTB.ClassA.Print(); 
        }
    }
}
namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("This is Class A with TeamA");
            }
        }
    }
}

namespace ProjectA
{
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("This is Class A with TeamB");
            }
        }
    }
}