using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Class2_Rectangle
    {
        // 成员变量
        //单行注释
        /*
         * 多行注释
         */
        double length;
        double width;
        //成员函数
        public void Acceptdetails()
        {
            length = 4.5;
            width = 3.5;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length : {0}", length);
            Console.WriteLine("Width : {0}", width);
            Console.WriteLine("Area : {0}", GetArea());
        }

    }

    //class ExecuteRectangle
    //{
    //    static void Main(string[] args)
    //    {
    //        Class2_Rectangle r = new Class2_Rectangle() ;
    //        r.Acceptdetails();
    //        r.Display();
    //        Console.ReadLine();
    //    }
    //}
}
