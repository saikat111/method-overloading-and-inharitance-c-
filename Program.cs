using System;

namespace Overload
{
    class A
    {
        public void p(int a)
        {
            Console.WriteLine("1st method");
        }
        public void p(int a,int b)
        {
            Console.WriteLine("2st method");
        }
        public void p(int a,int b,int c)
        {
            Console.WriteLine("3rd method");
        }



    }


    class Mainn
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.p(2);
            a.p(2,5);
            a.p(4,8,7);
        }
    }
}
