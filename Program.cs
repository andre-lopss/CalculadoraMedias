using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMedias
{
    class Program
    {
        static void medias()
        {
            Console.WriteLine("Digite a quantidade de notas a ser calculada:");
            int quantCalculada = Convert.ToInt32(Console.ReadLine());

            float soma = 0;

            for (int i = 1; i <= quantCalculada; i++)
            {
                Console.Write("Digite a " + i + "° nota: ");
                int notas = Convert.ToInt32(Console.ReadLine());
                if(notas > 10 || notas < 0)
                {
                    Console.Clear();
                    Console.WriteLine("As notas devem receber um valor entre 0 e 10");
                    Console.WriteLine("============================================");
                    medias();
                }
                else
                {
                    soma += notas;
                } 
            }

            double media = Math.Round((soma / quantCalculada), 2);

            Console.WriteLine(" ");
            Console.WriteLine("A média do aluno foi de " + media);

            if (media >= 6)
            {
                Console.WriteLine("Parabéns, você passou!");
            }
            else
            {
                Console.WriteLine("Você está em recuperação... :(");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Deseja calcular outra média?");
            Console.WriteLine("Digite 1 para sim");
            int intOp = Convert.ToInt32(Console.ReadLine());

            switch (intOp)
            {
                case 1:
                    Console.Clear();
                    medias();
                    break;
                default:
                    break;
            }
        }
 
    static void Main(string[] args)
        {
            medias();     
        }
    }
}
