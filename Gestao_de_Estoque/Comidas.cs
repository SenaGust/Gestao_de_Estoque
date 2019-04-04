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
        public Comidas(string id, string nome, int categoria, double preco, double mLucro, double imposto) : base(id, nome, categoria, preco, mLucro, imposto)
        {

        }
        #endregion

        #region Métodos Abstratos
        public override double CalcImposto()
        {
            return (PrecoCusto + MargemLucro) * Imposto;
        }

        public override double CalcPrecoVenda()
        {
            return PrecoCusto + MargemLucro + CalcImposto();
        }
        #endregion

        #region Métodos Interface
        public override string ToString()
        {
            return String.Format("Id: {0}; Categoria: Comidas; Nome do produto: {1}; Categoria: {2}; Custo: {3}; Margem de lucro: {4}",
                ID, NomeProduto, Categoria, PrecoCusto, MargemLucro);
        }
        #endregion
    }
}
