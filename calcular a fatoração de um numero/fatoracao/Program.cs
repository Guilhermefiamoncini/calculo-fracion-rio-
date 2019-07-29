using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fatoracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 total = 0;
           
            Console.WriteLine("digite um número inteiro");

            Int32 numinteiro = Convert.ToInt32(Console.ReadLine());

            Int32 frac = numinteiro - 1;

            //Console.WriteLine(total);

            total = numinteiro * frac;

            //Console.WriteLine(total);

            frac = frac - 1;
           
            while (frac > 0)
            {
                total = total * frac;
                frac = frac - 1;
                //Console.WriteLine(total);


            }
            Console.Write("o resultado do calculo fracionário de {0} ", numinteiro);
            Console.WriteLine("é de: " + total);
           



            Console.ReadKey();
        }

    }
}
