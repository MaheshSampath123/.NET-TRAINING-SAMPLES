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
        public void test2()
        {
            Console.WriteLine("Method 2");
        }
    }
    class InheritenceClass:Class1
    {
        public void test3()
        {
            Console.WriteLine("Method 3");
        }
        static void Main(string[] args)
        {
            InheritenceClass n = new InheritenceClass();
            n.test1();
            n.test2();
            n.test3();
            Console.ReadLine();
        }
    }
}
