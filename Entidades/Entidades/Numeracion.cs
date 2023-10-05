using System;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Net.Sockets;

namespace Entidades
{
    public class Numeracion
    {

        //Atribtos 

        private ESistema sistema;
        private double valorNumerico;

        //Propiedades

        public ESistema Sistema { get { return this.sistema; } }
        public string Valor { get { return this.valorNumerico.ToString(); } }


        // Constructores

        public Numeracion(double valor, ESistema sistema)
        {
            InicializarValores(valor.ToString(), sistema);
        }

        public Numeracion(string valor, ESistema sistema)
        {
            InicializarValores(valor, sistema);
        }

        //Métodos

        /// <summary>
        /// Convierte en caso de ser necesario, en base al sistema recibido por parámetros, un objeto Numeracion de decimal a binario
        /// </summary>
        /// <param name="Sistema"> Sistema númerico al cual queremos convertir nuestra instancia de Nuemracion</param>
        /// <returns>El objeto Numeración conertido a binario, caso contrario su Valor</returns>
        public string ConvertirA(ESistema Sistema)
        {
 
            if (Sistema == ESistema.Binario)
            {
                // Si es decimal y lo queres convertir a binario
                return this.DecimalABinario(this.Valor);
            }
            else
            {
                return this.Valor;
            }

        }

        /// <summary>
        /// Inicializa los valores del objeto y Si el valor recibido es un binario, lo convertirá a decimal antes de
        /// guardarlo, de lo contrario verificará que sea un numero decimal.
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="sistema"></param>
        private void InicializarValores(string valor, ESistema sistema)
        {
            if (!string.IsNullOrEmpty(valor) && sistema == ESistema.Binario)
            {
                this.valorNumerico = this.BinarioADecimal(valor);
            }
            else if (double.TryParse(valor, out double dec))
            {
                this.valorNumerico = dec;
            }
            else this.valorNumerico = double.MinValue;

        }


        /// <summary>
        /// Valida que la cadena recibida por parametros este compuesta SOLO por "0" y "1".
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>Verdadero, si se cumple la condición. De lo contrario falso</returns>
        private bool EsBinario(string valor)
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

        /// <summary>
        /// Convierte en caso de ser necesario, el entero recibido por parámetros a binario
        /// </summary>
        /// <param name="valor">Valor a convertir</param>
        /// <returns></returns>
        private string DecimalABinario(int valor)
        {
            if (valor == 0)
            {
                return "0"; 
            }
            string resultado = "";

            while (valor > 0)
            {
                int residuo = valor % 2;
                resultado = residuo + resultado;
                valor = valor / 2;
            }
            return resultado;
        }


        /// <summary>
        /// Convierte en caso de ser necesario, el string recibido por parámetros a binario
        /// </summary>
        /// <param name="valor">Valor a convertir, o un string representando que el string recibido por parámetros no es válido</param>
        /// <returns></returns>
        private string DecimalABinario(string valor)
        {
            if(int.TryParse(valor, out int valorInt))
            {
                if (valorInt == 0)
                {
                    return "0";
                }

                string resultado = "";

                while (valorInt > 0)
                {
                    int residuo = valorInt % 2;
                    resultado = residuo + resultado;
                    valorInt = valorInt / 2;
                }
                  return resultado;
            }
            else  return "Número inválido"; 
        }


        /// <summary>
        /// Valida que valor sea un numero binario
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>El número binario casteado a double, caso contrario 0</returns>
        private double BinarioADecimal(string valor)
        {
            if (EsBinario(valor))
            {
                int resultado = 0;
                int longitud = valor.Length;

                for (int i = 0; i < longitud; i++)
                {
                    int digito = int.Parse(valor[i].ToString());
                    int posicion = longitud - i - 1;
                    resultado += digito * (int)Math.Pow(2, posicion);
                }
                return resultado;
            }
            return 0;
        }


        //Sobrecarga de operadores de comparación

        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            return n1.sistema == n2.sistema;
        }

        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            return n1.sistema != n2.sistema;
        }

        public static bool operator ==(ESistema s, Numeracion n)
        {
            return n.sistema == s;
        }
        public static bool operator !=(ESistema s, Numeracion n)
        {
            return n.sistema != s;
        }

        //Sobrecarga de operadores aritméticos
        public static double operator +(Numeracion n1, Numeracion n2)
        {
            return n1.valorNumerico + n2.valorNumerico;
        }
        public static double operator -(Numeracion n1, Numeracion n2)
        {
            return n1.valorNumerico - n2.valorNumerico;
        }
        public static double operator /(Numeracion n1, Numeracion n2)
        {
            return n1.valorNumerico / n2.valorNumerico;
        }
        public static double operator *(Numeracion n1, Numeracion n2)
        {
            return n1.valorNumerico * n2.valorNumerico;
        }

    }
}