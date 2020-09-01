using System;

namespace DemoInheritanceQ3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //MyBaseClass mbc = new MyBaseClass();

            //Console.WriteLine(mbc);

            MySpecializedClass sc = new MySpecializedClass();

            //Console.WriteLine(sc);

            //if (sc is IMyInterface)
            //{
            //    (sc as IMyInterface).MyInterfaceMethod();
            //}

            if (sc is MyBaseClass)
            {
                
                Console.WriteLine((sc as MyBaseClass).MyBaseClassMethod());
            }

           

        }
    }
}
