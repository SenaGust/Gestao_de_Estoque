using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_de_Estoque
{
    abstract class Produto : IDado
    {
        #region Atributos
        public string ID { get; private set; }
        public string NomeProduto { get; private set; }
        public int Categoria { get; private set; }
        public double PrecoCusto { get; set; }
        public double MargemLucro { get; set; }

        #endregion

        #region Construtor
        public Produto(string ID, string NomeProduto, int Categoria, double PrecoCusto)
        {
            this.ID = ID;
            this.NomeProduto = NomeProduto;
            this.Categoria = Categoria;
            this.PrecoCusto = PrecoCusto;
        }
        #endregion

        #region Métodos Abstratos
        public abstract double CalcImposto();
        public abstract double CalcPrecoVenda();
        #endregion
    }
}
