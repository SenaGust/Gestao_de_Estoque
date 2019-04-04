using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_de_Estoque
{
    class Pedidos
    {
        public Produto Produto;
        int quantidade { get; set; } 
        double valor_ped { get; set; }
        public void Valor_pedido()
        {
            this.valor_ped=this.quantidade * Produto.PrecoCusto;
        }

    }
}
