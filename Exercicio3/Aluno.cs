﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Aluno : Pessoa
    {

        public Aluno(string nome): base(nome) { }
        public void Estudar()
        {
            Console.WriteLine("Estudando...");
        }
    }
}
