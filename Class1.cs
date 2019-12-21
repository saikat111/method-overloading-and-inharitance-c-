using System;
using System.Collections.Generic;
using System.Text;

namespace Overload
{
    class Class1
    {
        public void P()
        {
            Console.WriteLine("1st");
        }
    }
    class Class2:Class1
    {
        public void Pp()
        {
            Console.WriteLine("2st");
        }
    }
    class Class3:Class2
    {
        public void Ppp()
        {
            Console.WriteLine("3st");
        }
    }
    class Demo
    {
        public static void main(String[] args)
        {
            Class3 c3 = new Class3();
            c3.Ppp();
        }
    }
}
