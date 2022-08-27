using System;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class A
    {

        public virtual void SayHello()
        {
            Console.WriteLine("Hello");
        }

    }

    public class B : A
    {
        private int field;
        protected int field2;
        public int Property { get; set; }


        public B()
        {

        }


        public override void SayHello()
        {
            Console.WriteLine("World");
        }
    }

    public class C : A
    {
        public override void SayHello()
        {
            base.SayHello();
            Console.WriteLine("World");
        }
    }

    public class D : A
    {
        public  void SayHello()
        {
            Console.WriteLine("World");
        }
    }

















}
