using Entidades;
using System;
using System.Windows.Forms;

namespace Ejercicio_Integrador
{
    public partial class FrmCalculadora : Form
    {

        private Calculadora calculadora;

        public FrmCalculadora()
        {
            InitializeComponent();
            this.calculadora = new Calculadora("Falcone Alejo");
        }

        /// <summary>
        /// Inicializamos por default la calculadora con el radio button Decimal seleccionado y creamos la lista de operadores del ComboBox. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            this.rdbDecimal.Checked = true;
            this.cmbOperacion.DataSource = new object[] {"", "+", "-", "/", "*"};
        }

        /// <summary>
        /// Limpía los campos necesarios de a calculadora para poder operar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.calculadora.EliminarHistorialDeOperaciones();
            this.txtPrimerOperador.Text = string.Empty;
            this.txtSegundoOperador.Text = string.Empty;
            this.txtResultado.Text = $"Resultado:";
            this.MostrarHistorial();
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            //Llama tacitamente al evento closing del formulario, revisar método FrmCalculadora_FormClosing 
        }

        /// <summary>
        /// Obtenemos el valor ingresado en el campo del primer operando.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPrimerOperador_TextChanged(object sender, EventArgs e)
        {
        
        }

        private Numeracion GetOperador(string value)
        {
            if (Calculadora.Sistema == ESistema.Binario)
            {
                return new SistemaBinario(value);
            }
            else return new SistemaDecimal(value);
        }


        private void MostrarHistorial()
        {

        }


        /// <summary>
        /// Obtenemos el valor ingresado en el campo del segundo operando.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {
         
        }

        /// <summary>
        /// Creamos una instancia de Operacion con los valores ingresados en nuestra calculadora, y realizamos 
        /// la operación correspondientes, si el usuario no la determina esta será por defecto una suma.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {

            char operador;
            bool verificacion;
            calculadora.PrimerOperando = this.GetOperador(this.txtPrimerOperador.Text);
            calculadora.SegunddoOperando = this.GetOperador(this.txtPrimerOperador.Text);
            verificacion = char.TryParse(cmbOperacion.Text, out operador);
            this.calculadora.Calcular(operador);
            this.calculadora.ActualizarHistorialDeOperaciones(operador);
            this.txtResultado.Text = $"Resultado:{ calculadora.Resultado.Valor}";this.MostrarHistorial();




            if (!String.IsNullOrEmpty(txtSegundoOperador.Text) || !String.IsNullOrEmpty(txtSegundoOperador.Text))
            {
                

                SetResultado();


            }
            else MessageBox.Show("Por favor, complete todos los campos para poder realizar una operación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }


        /// <summary>
        /// Obtenemos el Sistema en el cual el usuario desea ver el resultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            Calculadora.Sistema = ESistema.Decimal;
        }

        /// <summary>
        /// Obtenemos el Sistema en el cual el usuario desea ver el resultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            Calculadora.Sistema = ESistema.Binario;
        }

        /// <summary>
        /// Convertimos en caso de ser necesario el resultado y lo mostramos.
        /// </summary>
        private void SetResultado()
        {

        }

        /// <summary>
        /// Pedímos una confirmación del usuario antes de cerrar la calculadora.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult salir = MessageBox.Show("Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (salir == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
