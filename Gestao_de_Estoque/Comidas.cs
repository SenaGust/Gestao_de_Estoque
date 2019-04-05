using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_de_Estoque
{
    class Comidas : Produto
    {
        #region Construtor
        public Comidas(string id, string nome, double preco, double mLucroMin, double mLucroMax) : base(id, nome, preco, mLucroMin, mLucroMax)
        {
            Imposto = 0.1;
        }
        #endregion

        #region Métodos Abstratos
        public override double CalcImposto()
        {
            return (PrecoCusto + (PrecoCusto * MargemLucroMIN)) * Imposto;
        }

        public override double CalcPrecoVenda()
        {
            return PrecoCusto + (PrecoCusto * MargemLucroMIN) + CalcImposto();
        }
        #endregion

        #region Métodos Interface
        public override string ToString()
        {
            return String.Format("Id: {0}; Categoria: Comidas; Nome do produto: {1}; Custo: {2}; Margem de lucro: {3}",
                ID, NomeProduto, PrecoCusto, MargemLucroMIN);
        }
        public bool Equals(Produto product)
        {
            return (this.ID == product.ID);
        }
        #endregion
    }
}
