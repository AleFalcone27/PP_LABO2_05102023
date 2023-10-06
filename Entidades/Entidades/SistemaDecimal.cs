using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaDecimal : Numeracion
    {

        public SistemaDecimal(string valor) : base(valor) 
        {
        
        }

        internal override double ValorNumerico
        {
            get 
            {
                 return (double)(this); 
            }
        }

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            if (sistema == ESistema.Decimal)
            {
                return this;
            }
            return this.DecimalABinario();
        }

        protected override bool EsNumeracionValida(string valor)
        {
            if(base.EsNumeracionValida (valor) && EsSistemaDecimalValido(valor))
            {
                return true;
            }
            else return false;  
        }

        private bool EsSistemaDecimalValido(string valor)
        {
            double valorDouble;
            if (double.TryParse(valor, out valorDouble))
            {
                return true;
            }
            else return false;
        }


        private SistemaBinario DecimalABinario()
        {

            double valor = this.ValorNumerico;

            if (valor < 0)
            {
                this.valor = "msgError";
            }
            string resultado = "";

            while (valor > 0)
            {
                int residuo = (int)this.ValorNumerico % 2;
                resultado = residuo + resultado;
                valor = this.ValorNumerico / 2;
            }
            return new SistemaBinario(resultado);
        }


        public static implicit operator SistemaDecimal(string valor)
        {
            return new SistemaDecimal(valor);
        }

        public static implicit operator SistemaDecimal(double valor)
        {
            return new SistemaDecimal(valor.ToString());
        }

    }
}
