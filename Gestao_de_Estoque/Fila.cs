using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_de_Estoque
{
    class Fila
    {
        public Elemento Primeiro { get; private set; } //controle
        public Elemento Ultimo { get; private set; } //controle

        public Fila()
        {
            this.Primeiro = new Elemento(null); //sentinela
            this.Ultimo = this.Primeiro; //no começo a primeira posição é igual a ultima
        }


        public void Enfileirar(IDado element)
        {
            Elemento novo = new Elemento(element);

            this.Ultimo.Prox = novo;
            novo = this.Ultimo;

        }

        public void Desenfileirar()
        {

        }

        public void ConsultaInicio()
        {

        }


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

        public bool Vazia()
        {
            return (this.Primeiro == this.Ultimo);
        }

        //public void UnirFilas(Fila fila)
        //{

        //}
    }
}
