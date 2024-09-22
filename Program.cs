using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cube
    {
        double r;
        public Cube()
        { }
        public Cube(double r)
        {
            this.r = r;
        }
        public void Print()
        {
            Console.WriteLine("Властивості куба:");
            Console.WriteLine($"Ребро = {r}");
            Console.WriteLine("");
        }
        public double Area()
        {
            double a = 6 * Math.Pow(r, 2);
            return a;
        }
        public double Volume()
        {
            double v = Math.Pow(r, 3);
            return v;
        }
        public bool Correct()
        {
            bool c = false;
            if (r > 0) c = true;
            return c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            try
            {
                Console.Write("Введіть довжину ребра = "); r = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("");
                Cube c = new Cube(r);
                c.Print();
                if (c.Correct())
                {
                    double a = c.Area();
                    double v = c.Volume();
                    Console.WriteLine($"Площа поверхні куба = {a:F3}");
                    Console.WriteLine($"Обсяг куба = {v:F3}");
                }
                else Console.WriteLine("Такого куба не існує");
            }
            catch
            {
                Console.WriteLine("\nСталася помилка!");
            }
            Console.ReadKey();
        }
    }
}