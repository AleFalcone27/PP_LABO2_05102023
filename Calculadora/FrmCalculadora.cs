using Entidades;
using System;
using System.Windows.Forms;

namespace Ejercicio_Integrador
{
    public partial class FrmCalculadora : Form
    {
        Operacion calculadora;
        Numeracion primerOperando;
        Numeracion segundoOperando;
        Numeracion resultado;
        ESistema sistema;

        public FrmCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializamos por default la calculadora con el radio button Decimal seleccionado y creamos la lista de operadores del ComboBox. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            this.rdbDecimal.Checked = true;
            this.operacion.DataSource = new object[] {"", "+", "-", "/", "*"};
        }

        /// <summary>
        /// Limpía los campos necesarios de a calculadora para poder operar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtPrimerOperador.Clear();
            this.txtSegundoOperador.Clear();
            this.operacion.Text = "";
            this.txtResultado.Text = "";
            this.HistListBox.Items.Clear(); 
            resultado = null;
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
            this.primerOperando = new Numeracion(txtPrimerOperador.Text, ESistema.Decimal);
        }

        /// <summary>
        /// Obtenemos el valor ingresado en el campo del segundo operando.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {
            this.segundoOperando = new Numeracion(txtSegundoOperador.Text, ESistema.Decimal);
        }

        /// <summary>
        /// Creamos una instancia de Operacion con los valores ingresados en nuestra calculadora, y realizamos 
        /// la operación correspondientes, si el usuario no la determina esta será por defecto una suma.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSegundoOperador.Text) || !String.IsNullOrEmpty(txtSegundoOperador.Text))
            {
                calculadora = new Operacion(primerOperando, segundoOperando);

                if (String.IsNullOrEmpty(operacion.Text))
                {
                    //Forzamos la entrada al default del switch.
                    this.resultado = calculadora.Operar('1');
                }
                else this.resultado = calculadora.Operar(char.Parse(operacion.Text));

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
            this.sistema = ESistema.Decimal;
        }

        /// <summary>
        /// Obtenemos el Sistema en el cual el usuario desea ver el resultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            this.sistema = ESistema.Binario;
        }

        /// <summary>
        /// Convertimos en caso de ser necesario el resultado y lo mostramos.
        /// </summary>
        private void SetResultado()
        {
            if (this.sistema == ESistema.Binario)
            {
                txtResultado.Text = (this.resultado.ConvertirA(ESistema.Binario).ToString());
            }
            else txtResultado.Text = resultado.Valor;
           
            HistListBox.Items.Add(txtResultado.Text);
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
