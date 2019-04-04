using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_de_Estoque
{
    class Material_Escritorio : Produto
    {
        

        public Material_Escritorio(string id, string nome, int categoria, double preco) : base (id,nome,categoria,preco)
        {
            
        }

        public override double CalcImposto()
        {
            throw new NotImplementedException();
        }

        //preço de custo, somado à margem de lucro, somado ao imposto que é calculado em cima do valor anterior
        public override double CalcPrecoVenda()
        {
            throw new NotImplementedException();
        }
    }
}
