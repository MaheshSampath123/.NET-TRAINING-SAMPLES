using System;
using System.Collections.Generic;
using System.Text;

namespace MainClass
{
    class Class1
    {
        public void test1()
        {
            Console.WriteLine("Method 1");
        }
    }
    class InheritenceClass:Class1
    {
        static void Main(string[] args)
        {
            InheritenceClass n = new InheritenceClass();
            n.test1();
            Console.ReadLine();
        }
    }
}
