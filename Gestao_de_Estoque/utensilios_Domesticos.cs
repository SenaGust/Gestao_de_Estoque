using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_de_Estoque
{
    class Utensilios_Domesticos : Produto
    {
        #region Construtor
        public Utensilios_Domesticos(string id, string nome, double preco, double mLucro) : base(id, nome, preco, mLucro)
        {
            Imposto = 0.35;
        }
        #endregion

        #region Métodos Abstratos
        public override double CalcImposto()
        {
            return (PrecoCusto + (PrecoCusto * MargemLucro)) * Imposto;
        }

        public override double CalcPrecoVenda()
        {
            return PrecoCusto + (PrecoCusto * MargemLucro) + CalcImposto();
        }
        #endregion

        #region Métodos Interface
        public override string ToString()
        {
            return String.Format("Id: {0}; Categoria: Utensilhos Domesticos; Nome do produto: {1}; Custo: {2}; Margem de lucro: {3}",
                ID, NomeProduto, PrecoCusto, MargemLucro);
        }
        #endregion
    }
}
