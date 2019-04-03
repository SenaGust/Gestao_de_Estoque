using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_de_Estoque
{
    abstract class Produto
    {
        public string ID { get; private set; }
        public string NomeProduto { get; private set; }
        public int Categoria { get; private set; }       
        public double PrecoCusto { get; set; }
        public double MargemLucro { get; set; }

        public Produto(string ID, string NomeProduto, int Categoria, double PrecoCusto)
        {
            this.ID = ID;
            this.NomeProduto = NomeProduto;
            this.Categoria = Categoria;
            this.PrecoCusto = PrecoCusto;
        }

        public abstract double CalcImposto();
        public abstract double CalcPrecoVenda();
    }
}
