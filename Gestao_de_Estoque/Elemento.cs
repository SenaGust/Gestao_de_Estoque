using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_de_Estoque
{
    class Elemento
    {
        public IDado MeuDado { get; set; }
        public Elemento Prox { get; set; }

        public Elemento(IDado dado)
        {
            this.MeuDado = dado;
        }
    }
}
