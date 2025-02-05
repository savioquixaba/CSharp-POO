using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Carro : IVeiculo
    {
        private int QuantidadeGasolina { get; set; }

        public Carro(int quantidadeGasolina)
        {
            QuantidadeGasolina = quantidadeGasolina;
        }

        public bool Abastecer(int quantidade)
        {
            QuantidadeGasolina += quantidade;
            return true;
        }

        public void Dirigir()
        {
            if(QuantidadeGasolina > 0)
            {
                Console.WriteLine("Dirigindo");
            }
            else { Console.WriteLine("Abasteça o Carro!"); }
        }
    }
}
