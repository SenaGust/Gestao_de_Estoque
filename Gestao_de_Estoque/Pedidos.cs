using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_de_Estoque
{
    class Pedidos : IDado
    {
        #region Atributos
        public Produto Produto { get; private set; }
        public int Quantidade { get; private set; }
        public double Valor_Total { get; private set; }
        #endregion

        #region Construtor
        public Pedidos(Produto produto, int quantidade, double valorTotal)
        {
            this.Produto = produto;
            this.Quantidade = quantidade;
            this.Valor_Total = this.Quantidade * Produto.PrecoCusto;
        }
        #endregion

        #region Métodos Interface
        public override string ToString()
        {
            return ("ID Produto: " + Produto.ID + "; Nome: " + Produto.NomeProduto + "; Quantidade: " + Quantidade + "; Preço: " + Valor_Total + ".");
        }
        #endregion
    }
}
