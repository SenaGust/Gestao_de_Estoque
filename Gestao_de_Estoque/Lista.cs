using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_de_Estoque
{
    class Lista
    {
        public Elemento Primeiro { get; private set; }
        public Elemento Ultimo { get; private set; }

        public override string ToString()
        {
            StringBuilder auxImpressao = new StringBuilder();
            Elemento atual = Primeiro;

            while (atual.Prox != null)
            {
                auxImpressao.AppendLine(atual.Prox.MeuDado.ToString());
                atual = atual.Prox;
            }

            return auxImpressao.ToString();
        }

        public void UnirListas(Lista lista)
        {

        }
    }
}
