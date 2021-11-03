using System;

namespace Subsets_Built
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    
    public class A
    {
        B b = new B();
    }
    public class B
    {
        A a = new A();
    }
    public class C : A
    {
        D d = new D();
    }
    public class D : A
    {
        C c = new C();
    }
}
