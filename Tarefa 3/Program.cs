using System;
using System.Linq;

namespace Desafio_Tecnico_Dev_Jr
{
    class Tarefa1


    {
        static void Main(string[] args)
        {
            //Inicialização de Arrays e Variaveis
            int[] arr = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            bool achei = false;
            //Input da Soma esperada
            Console.Write("Digite o valor da soma esperada: ");
            int num = Convert.ToInt32(Console.ReadLine());

            //Percorre o Array e Realiza e verifica as possíveis somas
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == num)
                    {
                        Console.WriteLine(num + " é a soma de " + arr[i] + " + " + arr[j]);
                        achei = true;
                    }
                    if (achei) break;
                }
            }
            //Mensagem caso não encontre a soma nos valores do Array 
            if (!achei) Console.WriteLine("Nenhuma Soma Possível dentre os valores do Array");
        }
    }
}