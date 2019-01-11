using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        private struct Retangulo
        {
            public double Base { get; set; }
            public double Altura { get; set; }

            public double Perimetro 
            {
                get { return 2 * (this.Base + this.Altura); }
            }

            public double Area 
            {
                get { return this.Base * this.Altura; }
            }

            public Retangulo(double @base, double altura) : this()
            {
                Base = @base;
                Altura = altura;
            }
        }

        static void Main(string[] args)
        {

            var ret = new Retangulo(1, 2);

            Console.WriteLine("Esse é o nosso retângulo:");
            Console.WriteLine("Base = {0} e altura = {1}", ret.Base, ret.Altura);
            Console.WriteLine("Perimetro = {0} e área = {1}", ret.Perimetro, ret.Area);
            Console.ReadLine();

        }
    }
}
