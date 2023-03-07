using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Intensivao.Fullstack.ConsoleApp.ExerciciosLogica
{
    internal class Exercicio1018
    {
        public static void Cedulas()

        {
            Console.WriteLine("Digite aqui o valor que deseja retirar no caixa");

            int[] notas = new int[7] { 100, 50, 20, 10, 5, 2, 1 };
            int valor = int.Parse(Console.ReadLine());

            
            Console.WriteLine(valor);

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine(valor / notas[i] + "nota(s) de R$ " + notas[i] + ",00");
                valor = (valor%notas[i]);

            }

            Console.ReadKey();
        }
    }
}
