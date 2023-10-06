using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        private string nombreAlumno;
        private List<string> operaciones;
        private Numeracion primerOperando; 
        private Numeracion segundoOperando;
        private Numeracion resultado;
        private static ESistema sistema;

        static Calculadora()
        {
            Calculadora.sistema = ESistema.Decimal;
        }

        public Calculadora() 
        {
            this.operaciones = new List<string>();
        }

        public Calculadora(string nombreAlumno)
        {
            this.nombreAlumno = nombreAlumno;
        }


        public string NombreAlumno
        {
            get { return this.nombreAlumno; }
            set { this.nombreAlumno = value; }
        }

        public string Operaciones
        {
            get
            {
                return this.Operaciones;
            }
        }

        public Numeracion Resultado
        {
            get
            {
                return this.resultado;
            }
        }

        public Numeracion PrimerOperando
        {
            get { return this.primerOperando; }
            set { this.primerOperando = value; }
        }

        public Numeracion SegunddoOperando
        {
            get { return this.segundoOperando; }
            set { this.segundoOperando = value; }
        }

        public static ESistema Sistema
        {
            get { return Calculadora.sistema; }
            set { Calculadora.sistema = value; }
        }


        public void ActualizarHistorialDeOperaciones(char operaciones)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.primerOperando.Valor} {this.segundoOperando.Valor}");
            this.operaciones.Add(sb.ToString());
        }

        public void EliminarHistorialDeOperaciones()
        {
            this.operaciones.Clear();
        }

        private Numeracion MapeaResultado(double valor)
        {
            return valor;
        }


        public void Calcular(char operador)
        {
            if ((this.primerOperando != null && this.segundoOperando != null) && (this.primerOperando == this.segundoOperando))
            {
                switch (operador)
                {
                    case '/':
                        this.resultado = MapeaResultado(this.primerOperando.ValorNumerico / this.segundoOperando.ValorNumerico);
                        break;
                    case '*':
                        this.resultado = MapeaResultado(this.primerOperando.ValorNumerico * this.segundoOperando.ValorNumerico);
                        break;
                    case '-':
                        this.resultado = MapeaResultado(this.primerOperando.ValorNumerico - this.segundoOperando.ValorNumerico);
                        break;
                    default:
                        this.resultado = MapeaResultado(this.primerOperando.ValorNumerico + this.segundoOperando.ValorNumerico);
                        break;
                }
            }
            else resultado = double.MinValue;
        }

    }
}
