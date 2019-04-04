using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_de_Estoque
{
    class Material_Escritorio : Produto
    {
        #region Construtor
        public Material_Escritorio(string id, string nome, int categoria, double preco, double mLucro, double imposto) : base(id, nome, categoria, preco, mLucro, imposto)
        {

        }
        #endregion

        #region Métodos Abstratos
        public override double CalcImposto()
        {
            return (PrecoCusto + MargemLucro) * Imposto;
        }

        //preço de custo, somado à margem de lucro, somado ao imposto que é calculado em cima do valor anterior
        public override double CalcPrecoVenda()
        {
            return PrecoCusto + MargemLucro + CalcImposto();
        }
        #endregion

        #region Métodos Interface
        public override string ToString()
        {
            return String.Format("Id: {0}; Categoria: Material de Escritorio; Nome do produto: {1}; Categoria: {2}; Custo: {3}; Margem de lucro: {4}",
                ID, NomeProduto, Categoria, PrecoCusto, MargemLucro);
        }
        #endregion
    }
}
