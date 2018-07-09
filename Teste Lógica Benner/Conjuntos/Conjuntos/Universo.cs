using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conjuntos
{
    class Universo
    {
        private int qtConjuntos;
        private IDictionary<Conjunto, int> conjuntos = new Dictionary<Conjunto, int>();

        public int QtConjunto { get => qtConjuntos; set => qtConjuntos = value; }


        public Universo(int qtConjuntos)
        {
            this.qtConjuntos = qtConjuntos;
            gerarConjuntos(qtConjuntos);
        }


        public void gerarConjuntos(int qtConjuntos)
        {
            for (int i = 1; i < qtConjuntos; i++)
            {
                var conjunto = new Conjunto(i);
                conjuntos.Add(conjunto, i);
            }
        }

        public bool conectar(int n1, int n2)
        {
            foreach (Conjunto conjunto in conjuntos.Keys)
            {
                conjunto.conectar(n1, n2);
            }
               
            return true;
        }

        public bool consultar(int n1, int n2)
        {
            bool existeConexao = false;
            foreach (Conjunto conjunto in conjuntos.Keys)
            {
                existeConexao = conjunto.consultar(n1, n2);

                if (existeConexao)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
