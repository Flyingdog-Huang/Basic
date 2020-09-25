using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Class7_operatorsAppl
    {
        static void Main(string[] args)
        {
            //int a = 21;
            //int b = 10;
            //int c;

            //c = a + b;
            //Console.WriteLine("Line 1 - c 的值是 {0}", c);
            //c = a - b;
            //Console.WriteLine("Line 2 - c 的值是 {0}", c);
            //c = a * b;
            //Console.WriteLine("Line 3 - c 的值是 {0}", c);
            //c = a / b;
            //Console.WriteLine("Line 4 - c 的值是 {0}", c);
            //c = a % b;
            //Console.WriteLine("Line 5 - c 的值是 {0}", c);

            ////++a先自加再赋值
            //c = ++a;
            //Console.WriteLine("Line 6 - c 的值是 {0}", c);

            ////此时a的值为22
            ////--a先自减运算再赋值
            //c = --a;
            //Console.WriteLine("Line 7 - c 的值是 {0}", c);
            //Console.ReadLine();
            //Console.ReadLine(); //会等待直到用户按下回车，一次读入一行
            //Console.ReadKey(); //则是等待用户按下任意键，一次读入一个字符。

            //c = a++: 先将 a 赋值给 c，再对 a 进行自增运算。
            //c = ++a: 先将 a 进行自增运算，再将 a 赋值给 c 。
            //c = a--: 先将 a 赋值给 c，再对 a 进行自减运算。
            //c = --a: 先将 a 进行自减运算，再将 a 赋值给 c 。

            //int a = 1;
            //int b;

            //a = 1;
            //b = a++;
            //Console.WriteLine("a = {0}", a);
            //Console.WriteLine("b = {0}", b);

            //a = 1;
            //b = a--;
            //Console.WriteLine("a = {0}", a);
            //Console.WriteLine("b = {0}", b);

            //a = 1;
            //b = ++a;
            //Console.WriteLine("a = {0}", a);
            //Console.WriteLine("b = {0}", b);

            //a = 1;
            //b = --a;
            //Console.WriteLine("a = {0}", a);
            //Console.WriteLine("b = {0}", b);

            //int a = 60;            //60 = 0011 1100 
            //int b = 13;            //13 = 0000 1101 
            //int c = 0;

            //c = a & b;           // 12 = 0000 1100 
            //Console.WriteLine("Line 1 - c 的值是 {0}", c);

            //c = a | b;           //61 = 0011 1101 
            //Console.WriteLine("Line 2 - c 的值是 {0}", c);

            //c = a ^ b;           //49 = 0011 0001 
            //Console.WriteLine("Line 3 - c 的值是 {0}", c);

            //c = ~a;               //-61 = 1100 0011 
            //Console.WriteLine("Line 4 - c 的值是 {0}", c);

            //c = a << 2;     //240 = 1111 0000 
            //Console.WriteLine("Line 5 - c 的值是 {0}", c);

            //c = a >> 2;     //15 = 0000 1111 
            //Console.WriteLine("Line 6 - c 的值是 {0}", c);
            //Console.ReadLine();

            //int a = 21;
            //int c;

            //c = a;
            //Console.WriteLine("Line 1 - =  c 的值 = {0}", c);

            //c += a;
            //Console.WriteLine("Line 2 - += c 的值 = {0}", c);

            //c -= a;
            //Console.WriteLine("Line 3 - -=  c 的值 = {0}", c);

            //c *= a;
            //Console.WriteLine("Line 4 - *=  c 的值 = {0}", c);

            //c /= a;
            //Console.WriteLine("Line 5 - /=  c 的值 = {0}", c);

            //c = 200;
            //c %= a;
            //Console.WriteLine("Line 6 - %=  c 的值 = {0}", c);

            //c <<= 2;
            //Console.WriteLine("Line 7 - <<=  c 的值 = {0}", c);

            //c >>= 2;
            //Console.WriteLine("Line 8 - >>=  c 的值 = {0}", c);

            //c &= 2;
            //Console.WriteLine("Line 9 - &=  c 的值 = {0}", c);

            //c ^= 2;
            //Console.WriteLine("Line 10 - ^=  c 的值 = {0}", c);

            //c |= 2;
            //Console.WriteLine("Line 11 - |=  c 的值 = {0}", c);
            //Console.ReadLine();

            //// sizeof 运算符的实例 
            //Console.WriteLine("int 的大小是 {0}", sizeof(int));
            //Console.WriteLine("short 的大小是 {0}", sizeof(short));
            //Console.WriteLine("double 的大小是 {0}", sizeof(double));

            ////三元运算符的实例 
            //int a, b;
            //a = 10;
            //b = (a == 1) ? 20 : 30;
            //Console.WriteLine("b 的值是 {0}", b);

            //b = (a == 10) ? 20 : 30;
            //Console.WriteLine("b 的值是 {0}", b);
            //Console.ReadLine();

            //int a = 20;
            //int b = 10;
            //int c = 15;
            //int d = 5;
            //int e;
            //e = (a + b) * c / d;     // ( 30 * 15 ) / 5
            //Console.WriteLine("(a + b) * c / d 的值是 {0}", e);

            //e = ((a + b) * c) / d;   // (30 * 15 ) / 5
            //Console.WriteLine("((a + b) * c) / d 的值是 {0}", e);

            //e = (a + b) * (c / d);   // (30) * (15/5)
            //Console.WriteLine("(a + b) * (c / d) 的值是 {0}", e);

            //e = a + (b * c) / d;    //  20 + (150/5)
            //Console.WriteLine("a + (b * c) / d 的值是 {0}", e);
            //Console.ReadLine();


        }
    }
}
