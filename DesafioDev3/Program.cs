using System;

namespace DesafioDev3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] lista = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            bool contemConta = false;

            Console.Write("Digite o valor da soma esperada: ");
            int valorParseado = 0;
            if (!int.TryParse(Console.ReadLine(), out valorParseado))
            {
                Console.WriteLine("Valor digitado inválido. Digite apenas inteiros");
                return;
            }
            for (int i = 0; i < lista.Length - 1; i++)
            {
                for (int j = i + 1; j < lista.Length; j++)
                {
                    if (lista[i] + lista[j] == valorParseado)
                    {
                        Console.WriteLine($"{valorParseado} é a soma de {lista[i]} + {lista[j]}");
                        contemConta = true;
                    }
                    if (contemConta) return;
                }
            }
            if (!contemConta) Console.WriteLine("Nenhuma Soma Possível dentre os valores do Array");
        }
    }
}
