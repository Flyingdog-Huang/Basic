using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Class6_constTest
    {
        class SampleClass
        {
            public int x;
            public int y;
            public const int c1 = 5;
            public const int c2 = c1 + 5;

            public SampleClass(int p1, int p2)
            {
                x = p1;
                y = p2;
            }
        }
        /*
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello\tWorld\n\n");//制表符
            //Console.WriteLine(@"Hello\tWorld\n\n");//@的作用
            //Console.ReadLine();

//            string a = "hello, world";                  // hello, world
//            string b = @"hello, world";               // hello, world
//            string c = "hello \t world";               // hello     world
//            string d = @"hello \t world";               // hello \t world
//            string e = "Joe said \"Hello\" to me";      // Joe said "Hello" to me
//            string f = @"Joe said ""Hello"" to me";   // Joe said "Hello" to me
//            string g = "\\\\server\\share\\file.txt";   // \\server\share\file.txt
//            string h = @"\\server\share\file.txt";      // \\server\share\file.txt
//            string i = "one\r\ntwo\r\nthree";
//            string j = @"one
//two
//three";

            //定义常量
            //const <data_type> <constant_name> = value;

            SampleClass mc = new SampleClass(11, 22);
            Console.WriteLine("x = {0}, y = {1}", mc.x, mc.y);
            Console.WriteLine("c1 = {0}, c2 = {1}",
                SampleClass.c1, SampleClass.c2);

        }*/
    }
}
