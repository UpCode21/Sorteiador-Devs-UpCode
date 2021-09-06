using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorteioUpCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int repetidor = 0;
            while(repetidor == 0)
            {
                try
                {
                    Sorteia();
                }
                catch(FormatException)
                {

                    Console.WriteLine("Digite Numeros Validos!");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Quantidade de sorteios/Equipes excede o Limite!!!");
                }
                catch (Exception)
                {
                    Console.WriteLine("Algum Erro Inesperado.");
                }
                Repeat:
                Console.WriteLine("Deseja Repetir o Sorteio?");
                string R = Console.ReadLine();
                string resposta = R.ToLower();
                if (resposta == "sim" || resposta == "s")
                {                    
                    Console.Clear();
                }
                else if (resposta == "nao" || resposta == "n")
                {
                    Console.WriteLine("Finalizando Aplicação!!!");
                    repetidor++;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Respopsta Invalida");
                    goto Repeat;
                }
            }
            
            Console.ReadLine();
        }

        public static void Sorteia()
        {
            List<string> nomes = new List<string>()
            {
                "Yuri",
                "Julio Cesar",
                "Leone",
                "Daniel Souza",
                "Gisa",
                "Germano",
                "Thiago",
                "Cid",
                "Hanna",
                "Yvens",
                "Diego",
                "Flavio",
                "Davi",
                "João Pedro",
                "Erick",
                "Lucas",
                "Hellen",
                "Leonardo",
                "Matheus",
                "Patrick",
                "Ana Paula",
                "Hadson",
                "Alan",
                "Arthur",
                "Cleylton",
                "Daniel Santos",
                "Edvaldo",
                "Isadora",
                "Ismael",
                "Romario"
            };

            Random rdm = new Random();
            Console.Write("Defina quantos grupos: ");
            int quantidade = int.Parse(Console.ReadLine());
            Console.Write("Quantidade na equipe: ");
            int equipe = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int contador = 0;
            int numeral = 1;

            while (contador < quantidade)
            {
                for (int i = 0; i < equipe; i++)
                {
                    int sorteio = rdm.Next(nomes.Count);
                    Console.WriteLine(numeral + ": " + nomes[sorteio]);
                    nomes.RemoveAt(sorteio);
                    numeral++;
                }

                Console.WriteLine();
                contador++;
            }
        }
    }
}
