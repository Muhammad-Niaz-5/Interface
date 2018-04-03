using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Lab_8_ques_1
{
    interface I1  
    {  
        int addition(int a, int b);  
    }  
    interface I2  
    {  
        int subtraction(int c, int d);  
    }  
    interface I3  
    {  
        int multiplication(int e, int f);  
    }  
    interface I4  
    {  
        float division(float g, float h);  
    }
    class result : I1, I2, I3, I4
    {
        public int add;
        public int addition(int a, int b)
        {
            return add = a + b;
        }
        public int sub;
        public int subtraction(int c, int d)
        {
            return sub = c - d;
        }
        public int product;
        public int multiplication(int e, int f)
        {
            return product = e * f;
        }
        public float div;
        public float division(float g, float h)
        {
            return div = g / h;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
              result r = new result();  
                r.addition(15, 30);  
                r.subtraction(23, 12);  
                r.multiplication(9, 5);  
                r.division(15, 9);   
                Console.WriteLine("Addition:       " + r.add);  
                Console.WriteLine("Substraction:   " + r.sub);  
                Console.WriteLine("Multiplication: " + r.product);  
                Console.WriteLine("Division:       " + r.div);  
                Console.ReadKey();
        }
    }
}