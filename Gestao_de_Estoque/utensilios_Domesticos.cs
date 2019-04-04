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
        public Utensilios_Domesticos(string id, string nome, int categoria, double preco) : base(id, nome, categoria, preco)
        {

        }
        #endregion

        #region Métodos Abstratos
        public override double CalcImposto()
        {
            throw new NotImplementedException();
        }

        public override double CalcPrecoVenda()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Métodos Interface
        public override string ToString()
        {
            return String.Format("Id: {0}; Categoria: Utensilhos Domesticos; Nome do produto: {1}; Categoria: {2}; Custo: {3}; Margem de lucro: {4}",
                ID, NomeProduto, Categoria, PrecoCusto, MargemLucro);
        }
        #endregion
    }
}
