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
            catch (NullReferenceException excecao)
            {
                Console.WriteLine(excecao.Message);
                Console.WriteLine(excecao.StackTrace);
            }

            Console.ReadLine();
            
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
            ClasseTeste teste = new ClasseTeste();
            teste = null;
            teste.MetodoTestre(3);// método criado para gerar erro de NullReference
            Dividir(10, divisor);
        }
    }


}

