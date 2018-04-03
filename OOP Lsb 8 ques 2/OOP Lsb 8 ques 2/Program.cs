using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Lsb_8_ques_2
{
    sealed class Info    
    {
        public string Person()
        {
            return "Zain Sarfaraz";
        }
    }
    class Program
    {
        //abstract class shape
        //{
        //    public abstract double Area();
        //}
        //class Circle : shape
        //{
        //    double radius = 0;
        //    public Circle(double r)
        //    {
        //        radius = r;
        //    }
        //    public override double Area()
        //    {
        //        return Math.PI * radius * radius;
        //    }
        //}


       
        static void Main(string[] args)
        {   
            Info obj = new Info();
            string Name = obj.Person();
            Console.WriteLine(Name);
            Console.ReadLine(); 





            //Circle c = new Circle(2);
            //Console.WriteLine("Area is = " + c.Area());
            //Console.ReadKey();
        }
    }
}
