using System;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Net.Sockets;

namespace Entidades
{
    public abstract class Numeracion
    {
        static string msgError;
        protected string valor;

        private Numeracion()
        {
            Numeracion.msgError = "Número Invalido";
        }

        protected Numeracion(string valor)
        {
            InicializaValor(valor);
        }

        public string Valor
        {
            get { return this.valor; }
        }

        abstract internal double ValorNumerico { get; }

        public abstract Numeracion CambiarSistemaDeNumeracion(ESistema sistema);

        /// <summary>
        /// Verificara que la cadena recibida no sea nula o con espacios en blanco.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        protected virtual bool EsNumeracionValida(string valor)
        {
            return !String.IsNullOrWhiteSpace(valor);
        }


        /// <summary>
        /// validará que el valor
        ///  recibido sea una numeración valida, de lo contrario el atributo
        ///  almacenará un mensaje de error.
        /// </summary>
        /// <param name="valor"></param>
        private void InicializaValor(string valor)
        {
            if (EsNumeracionValida(valor))
            {
                this.valor = valor;
            }
            else this.valor = "msgError";
        }


        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            return ((n1.GetType() == n2.GetType()) && (n1 != null && n2 != null)); 
        }

        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            return (n1 != null && n2 != null);
        }

        public static explicit operator double(Numeracion numeracion)
        {
            return numeracion.ValorNumerico;
        }

        public static implicit operator Numeracion(double v)
        {
            throw new NotImplementedException();
        }
    }
}