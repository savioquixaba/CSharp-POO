using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Pessoa
    {
        private string nome;

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public string Nome
        {
            get; set;
        }

        public override string ToString()
        {
            return Nome;
        }

    }
}
