using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_de_Estoque
{
    class Produto
    {
        public string ID { get; private set; }
        public string NomeProduto { get; private set; }
        public int Categoria { get; private set; }        

        public Produto()
        {
            ID = "0-0000";
            NomeProduto = "AAAAAA";
            Categoria = 0;
        }

        public Produto(string id, string nomeProduto, int categoria)
        {
            this.ID = id;
            this.NomeProduto = nomeProduto;
            this.Categoria = categoria;
        }
    }
}
