using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class LivroFotos
    {
        private int numPaginas;
        public LivroFotos()
        {
            numPaginas = 16;
        }
        public LivroFotos(int quantidade)
        {
            numPaginas = quantidade;
        }
        
        public int NumPaginas
        {
            get { return numPaginas; }
            set { numPaginas = value; }
        }
    }
}
