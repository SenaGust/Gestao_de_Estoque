using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_de_Estoque
{
    class Utensilios_Domesticos: Produto
    {
        public Utensilios_Domesticos(string id, string nome, int categoria, double preco) : base(id, nome, categoria, preco)
        {

        }

        public override double CalcImposto()
        {
            throw new NotImplementedException();
        }

        public override double CalcPrecoVenda()
        {
            throw new NotImplementedException();
        }
    }
}
