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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            Console.ReadLine();
            
        }
        public static int Dividir(int dividendo, int divisor)
        {
            try
            {
                return dividendo / divisor;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("O dividendo era " + dividendo + " e o divisor era " + divisor);
                Console.WriteLine(e.Message);
                throw; //O throw serve para quando o método exige retorno, mas há um erro de compilação, então ele sai do método
                // Nada mais pode ser executado depois do throw
            }
            
        }

        public static void Metodo()
        {
            TestarDivisao(0);
        }

        public static void TestarDivisao(int divisor)
        {
            ClasseTeste teste = new ClasseTeste();
            teste = null;
            //teste.MetodoTestre(3);// método criado para gerar erro de NullReference
            Dividir(10, divisor);
        
        }
    }


}

