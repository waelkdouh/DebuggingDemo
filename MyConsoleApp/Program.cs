using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                Age = 42,
                FirstName = "wael",
                LastName = "kdouh"
            };

            person.LastName = "new Name";

            int i = 10;
            i++;
            i++;
            i++;
            Foo();
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            i++;
            Foo();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //string o1 = "test";
            //string o2 = o1;
            //string o3 = o2;

            //int i = FooBar();
            //try
            //{
            //    throw new ArgumentException();
            //}
            //catch (Exception)
            //{
            //}

            //Console.ReadLine();
            //Console.WriteLine("Hello");

        }

        private static int FooBar()
        {
            return 100;
        }

        private static void Foo()
        {
            for (int i = 0; i < 1000; i++)
            {

            }
            Bar();
        }

        private static void Bar()
        {
            string s = "!";
            int z = 42;
        }

        private static int Add(int num1, int num2)
        {
            return num1 +num2;
        }

    }
}
