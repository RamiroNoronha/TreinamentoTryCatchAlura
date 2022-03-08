using System;

namespace TreinandoTryCatchAlura
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Metodo();
            }
            catch (DivideByZeroException excecao)
            {

                Console.WriteLine(excecao.Message);
                Console.WriteLine(excecao.StackTrace);
            }
            
        }
        public static int Dividir(int dividendo, int divisor)
        {
            return dividendo / divisor;
        }

        public static void Metodo()
        {
            TestarDivisao(0);
        }

        public static void TestarDivisao(int divisor)
        {
            Dividir(10, divisor);
        }
    }


}

