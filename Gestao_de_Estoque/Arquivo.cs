using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gestao_de_Estoque
{
    static class Arquivo
    {
        public static Fila Carregar_dados(string arquivo,Fila [] vet)
        {
            Fila produtos = new Fila();
            int contador = 0;

            if (!File.Exists(arquivo))
            {
                StreamWriter arq = new StreamWriter(arquivo);
                arq.Close();
            }

            StreamReader arquivoLeitura = new StreamReader(arquivo);
            string linha;
            string[] vetorAux;

            while (!arquivoLeitura.EndOfStream)
            {
                contador++;
                linha = arquivoLeitura.ReadLine();
                vetorAux = linha.Split(';');
                if (vetorAux.Length == 6)
                {
                    IDado dado = null;

                    switch (int.Parse(vetorAux[0]))
                    {
                        case 1:
                            dado = new Bebidas(vetorAux[1], vetorAux[2], Convert.ToDouble(vetorAux[3]), double.Parse(vetorAux[4]), double.Parse(vetorAux[5])); //instanciando um novo produto
                            vet[0].Enfileirar(dado);
                            break;
                        case 2:
                            dado = new Comidas(vetorAux[1], vetorAux[2], Convert.ToDouble(vetorAux[3]), double.Parse(vetorAux[4]), double.Parse(vetorAux[5]));
                            vet[1].Enfileirar(dado);
                            break;
                        case 3:
                            dado = new Material_Escritorio(vetorAux[1], vetorAux[2], Convert.ToDouble(vetorAux[3]), double.Parse(vetorAux[4]), double.Parse(vetorAux[5]));
                            vet[2].Enfileirar(dado);
                            break;
                        case 4:
                            dado = new Utensilios_Domesticos(vetorAux[1], vetorAux[2], Convert.ToDouble(vetorAux[3]), double.Parse(vetorAux[4]), double.Parse(vetorAux[5]));
                            vet[3].Enfileirar(dado);
                            break;
                        default:

                            break;

                    }
                    produtos.Enfileirar(dado);
                }
            }

            return produtos;
        } 
    }
}
