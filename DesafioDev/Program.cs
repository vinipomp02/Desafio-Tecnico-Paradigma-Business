using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioDev
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listaFinal = new int[7] { 7, 5, 3, 9, 6, 4, 1 };
            int[] listaInicial = new int[7];
            listaFinal.CopyTo(listaInicial, 0);

            for (int i = 0; i < listaFinal.Length; i++)
            {
                listaFinal[i] = (listaFinal[i] == 9) ? 5 : listaFinal[i];
            }

            listaFinal = listaFinal.Where((source, index) => index != 5).ToArray();

            Console.WriteLine($"Array Inicial: [{string.Join(" , ", listaInicial)}]");
            Console.WriteLine($"Array Final: [{string.Join(" , ", listaFinal)}]");
            Console.WriteLine($"A Soma dos Valores do Array Final é: {listaFinal.Sum(x => x)}");
        }
    }

}






