﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_de_Estoque
{
    abstract class Produto : IDado
    {
        #region Atributos
        public string ID { get; private set; }
        public string NomeProduto { get; private set; }        
        public double PrecoCusto { get; set; }
        public double MargemLucroMIN { get; set; }
        public double MargemLucroMAX { get; set; }
        public double Imposto { get; set; }
        #endregion

        #region Construtor
        public Produto(string ID, string NomeProduto, double PrecoCusto, double MargemLucroMIN, double MargemLucroMAX)
        {
            this.ID = ID;
            this.NomeProduto = NomeProduto;            
            this.PrecoCusto = PrecoCusto;
            this.MargemLucroMIN = MargemLucroMIN;
            this.MargemLucroMAX = MargemLucroMAX;
        }
        #endregion

        #region Métodos Abstratos
        public abstract double CalcImposto();
        public abstract double CalcPrecoVenda();
        #endregion
    }
}
