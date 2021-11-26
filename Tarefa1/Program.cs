using System;
using System.Linq;

namespace Desafio_Tecnico_Dev_Jr
{
    class Tarefa1


    {
        static void Main(string[] args)
        {
            //Incializa Variáveis e Arrays
            int[] final = new int[7] { 7, 5, 3, 9, 6, 4, 1 };
            int[] inicial = new int[7];
            final.CopyTo(inicial, 0);
            int soma = 0;
            //Laço para Trocar o 9 por 5
            for (int i = 0; i < final.Length; i++)
            {
                final[i] = (final[i] == 9) ? 5 : final[i];
            }
            //Remove o 4 do Array
            final = final.Where((source, index) => index != 5).ToArray();
            //Soma Valores do Array
            foreach (int inteiro in final)
            {
                soma += inteiro;
            }
            //Mostra os valores pedidos
            Console.WriteLine("Array Inicial: { " + String.Join(" , ", inicial) + " }");
            Console.WriteLine("Array Final: { " + String.Join(" , ", final) + " }");
            Console.WriteLine("A Soma dos Valores do Array Final é: " + soma);
        }
    }

}
