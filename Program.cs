using System;

namespace Basic
{
    class Program
    {
        // 不能定义多个入口点（Main）
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.ReadKey();

            Class2_Rectangle r = new Class2_Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();


        }
    }
}
