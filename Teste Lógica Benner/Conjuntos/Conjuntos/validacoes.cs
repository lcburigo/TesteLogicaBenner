using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conjuntos
{
    class Validacoes
    {
        public bool validaConexoes(string [] validaConectados, Universo universo)
        {
            bool n1 = false;
            bool n2 = false;
            int[] conectados = new int[2];

            if (validaConectados == null)
            {
                Console.WriteLine("Informação inválida!");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Vamos tentar novamente?");
                Console.ReadLine();
                return false;
            }

            if (validaConectados.Length != 2)
            {
                Console.WriteLine("Informação inválida!");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Vamos tentar novamente?");
                Console.ReadLine();
                return false;
            }

            n1 = int.TryParse(validaConectados[0], out conectados[0]);
            n2 = int.TryParse(validaConectados[1], out conectados[1]);

            if (!n1 || !n2)
            {
                Console.WriteLine("Informação inválida!");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Vamos tentar novamente?");
                Console.ReadLine();
                return false;
            }

            if (conectados.Length != conectados.Distinct().Count())
            {
                Console.WriteLine("Informação inválida!");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Vamos tentar novamente?");
                Console.WriteLine("Os números informados precisam ser diferentes!");
                Console.ReadLine();
                return false;
            }

            if (conectados[0] < 1 || conectados[1] < 1)
            {
                Console.WriteLine("Informação inválida!");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Vamos tentar novamente?");
                Console.WriteLine("Os números informados devem ser numeros inteiros positivos!");
                Console.ReadLine();
                return false;
            }

            if (conectados[0] > universo.QtConjunto || conectados[1] > universo.QtConjunto)
            {
                Console.WriteLine("Informação inválida!");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Vamos tentar novamente?");
                Console.WriteLine("Os números devem ser de 1 à " + universo.QtConjunto);
                Console.ReadLine();
                return false;
            }

            return true;
        }
    }
}
