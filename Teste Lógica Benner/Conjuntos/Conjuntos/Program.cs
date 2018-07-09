using System;
using System.Collections;
using System.Collections.Generic;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            int nrElementos = 0;
            string entrada = "";
            bool isNumeroInteiro = false;
            string[] dsConectado;
            int[] nrConectado;
            char continuarConectando = ' ';
            char consultar = ' ';

            try
            {

                Validacoes valicao = new Validacoes();
                Console.WriteLine("Ola, vamos começar?");
                Console.WriteLine("Informe um número positivo inteiro para determinar o número de elementos:");
                entrada = Console.ReadLine();

                while (isNumeroInteiro == false)
                {
                    isNumeroInteiro = int.TryParse(entrada, out nrElementos);
                    if (!isNumeroInteiro && nrElementos < 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Informação inválida!");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Vamos tentar novamente?");
                        Console.WriteLine("Informe um número positivo inteiro para determinar o número de elementos:");
                        entrada = Console.ReadLine();
                    }
                }
                Universo universo = new Universo(nrElementos);
                
                do
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Agora informe 2 numeros diferentes separados por ifem (x-y)");
                        dsConectado = Console.ReadLine().Split("-");
                    } while (!valicao.validaConexoes(dsConectado, universo));

                    nrConectado = Array.ConvertAll(dsConectado, Int32.Parse);
                    universo.conectar(nrConectado[0], nrConectado[1]);

                    Console.Write("Deseja inserir mais uma conexão ? Digite [S] se quiser continuar! ");
                    continuarConectando = Console.ReadKey().KeyChar;
                } while (continuarConectando == 's' || continuarConectando == 'S');

                Console.Clear();
                Console.WriteLine("Deseja consultar alguma conexão? Digite [S] se quiser continuar!");
                consultar = Console.ReadKey().KeyChar;

                while (consultar == 's' || consultar == 'S')
                {
                    Console.Clear();
                    Console.WriteLine("Informe 2 numeros diferentes separados por ifem (x-y) para consulta!");
                    do
                    {
                        dsConectado = Console.ReadLine().Split("-");
                    } while (!valicao.validaConexoes(dsConectado, universo));

                    nrConectado = Array.ConvertAll(dsConectado, Int32.Parse);
                    if (universo.consultar(nrConectado[0], nrConectado[1]))
                    {
                        Console.WriteLine("Os números " + nrConectado[0] + " e " + nrConectado[1] + " estão conectados!");
                    }
                    else
                    {
                        Console.WriteLine("Os números " + nrConectado[0] + " e " + nrConectado[1] + " não estão conectados!");
                    }

                    Console.Write("Deseja consultar mais uma conexão ? Digite [S] se quiser continuar! ");
                    consultar = Console.ReadKey().KeyChar;
                }
                Console.Clear();
                Console.Write("Até mais!");
                consultar = Console.ReadKey().KeyChar;
            }

            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine("ERRO: {0}", e.Message.ToUpper() + "Tecle enter para finalizar!");
            }
        }
    }
}
