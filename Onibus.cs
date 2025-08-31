using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastrarVeiculosProva
{
    internal class Onibus : Veiculo
    {
        protected int assentos;

 
        public int Assentos { get => assentos; set => assentos = value; }

        public Onibus(int assentos, string placa, int ano) : base(placa, ano)
        {
            this.assentos = assentos;
        }
        public override double Alugar()
        {
            double diaria = (this.assentos * 30) - (2025 - this.ano) * 70;
            return diaria;
        }

    }
}
