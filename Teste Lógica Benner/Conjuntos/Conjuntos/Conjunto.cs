using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Conjuntos
{
    class Conjunto
    {
        private ArrayList conjunto = new ArrayList();
        private int idConjunto;
        public int IdConjunto { get => idConjunto; set => idConjunto = value; }

        public Conjunto(int idConjunto)
        {
            this.idConjunto = idConjunto;
            conjunto.Add(idConjunto);
        }



        public bool conectar(int n1, int n2)
        {
            bool n1Existe = false;
            bool n2Existe = false;

            foreach (int item in conjunto)
            {
                if (item == n1)
                {
                    n1Existe = true;
                }

                if (item == n2)
                {
                    n2Existe = true;
                }

                if (n1Existe && n2Existe)
                {
                    return true;
                }

            }

            if (!n1Existe && !n2Existe)
            {
                return false;
            }

            if (n1Existe)
            {
                conjunto.Add(n2);
            }
            else
            {
                conjunto.Add(n1);
            }

            return true;
        }

        public bool consultar(int n1, int n2)
        {
            bool n1Existe = false;
            bool n2Existe = false;

            foreach (int item in conjunto)
            {
                if (item == n1)
                {
                    n1Existe = true;
                }

                if (item == n2)
                {
                    n2Existe = true;
                }

                if (n1Existe && n2Existe)
                {
                    return true;
                }
            }
                return false;
        }

    }
}
