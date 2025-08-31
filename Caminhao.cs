using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastrarVeiculosProva
{
    internal class Caminhao : Veiculo
    {
        protected int eixos;
        public int Eixos { get => eixos; set => eixos = value; }
        public Caminhao(int eixos, string placa, int ano) : base(placa, ano)
        {
            this.eixos = eixos;
        }
        public override double Alugar()
        {
            double diaria = this.eixos * 300 - (2025 - this.ano) * 50;
            return diaria;
        }


    }
}
