using System;

namespace VerificaQuadrante
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            Console.WriteLine("Insira o valor da cordenada X:");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor da cordenada Y:");
            y = double.Parse(Console.ReadLine());
            VerificaQuadrante(x,y);
        }
        static void VerificaQuadrante(double x, double y)
        {

            if(x>0 && y > 0)
            {
                Console.WriteLine("Essas cordenadas dão no quadrante 1");
            }
            else if(x < 0 && y > 0)
            {
                Console.WriteLine("Essas cordenadas dão no quadrante 2");
            }
            else if(x < 0 && y < 0)
            {
                Console.WriteLine("Essas cordenadas dão no quadrante 3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Essas cordenadas dão no quadrante 4");
            }
            else
            {
                Console.WriteLine("Cordenada centralizada");
            }
            Console.ReadKey();
        }
    }
}
