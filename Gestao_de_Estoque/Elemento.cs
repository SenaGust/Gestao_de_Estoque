using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_de_Estoque
{
    class Elemento
    {        
        public Elemento Prox { get; set; }

        public Produto produto { get; set; }

        public Elemento(Produto produto)
        {
            this.produto = produto;
        }
    }
}
