using System;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace Entidades
{
    public class SistemaBinario : Numeracion
    {


        public SistemaBinario(string valor) : base(valor)
        {

        }

        internal override double ValorNumerico
        {
            get { return (double)(this); }
        }

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            if (sistema == ESistema.Binario)
            {
                return this;
            }
            else return this.BinarioADecimal();
        }


        private SistemaDecimal BinarioADecimal()
        {
            if (this.valor != "msgError")
            {
                int resultado = 0;
                int longitud = valor.Length;

                for (int i = 0; i < longitud; i++)
                {
                    int digito = int.Parse(valor[i].ToString());
                    int posicion = longitud - i - 1;
                    resultado += digito * (int)Math.Pow(2, posicion);
                }
                return new SistemaDecimal(resultado.ToString());
            }
            return new SistemaDecimal(double.MinValue.ToString());
        }





        /// <summary>
        /// verificara que la cadena recibida no sea
        /// nula o con espacios vacíos y adicionalmente que sea un sistema binario
        /// valido.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        protected override bool EsNumeracionValida(string valor)
        {
            if (base.EsNumeracionValida(valor) && EsSistemaBinarioValido(valor))
            {
                return true;
            }
            else return false;
        }

        /// <summary>
        /// verificara que la cadena recibida solo posea 1 (unos) o 0 (ceros).
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        private bool EsSistemaBinarioValido(string valor)
        {
            foreach (var c in valor)
            {
                if (c.ToString() != "0" || c.ToString() != "1")
                {
                    return false;
                }
                else return true;
            }
            return true;
        }


        public static implicit operator SistemaBinario(string valor)
        {
            return new SistemaBinario(valor);
        }

    }
}
