using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Ejercicio_Integrador
{
    partial class FrmCalculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculadora));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSegundoOperador = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.rdbBinario = new System.Windows.Forms.RadioButton();
            this.rdbDecimal = new System.Windows.Forms.RadioButton();
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtPrimerOperador = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.Label();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(49, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "RESULTADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Primer operando";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(308, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Segundo operando";
            // 
            // txtSegundoOperador
            // 
            this.txtSegundoOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSegundoOperador.Location = new System.Drawing.Point(320, 206);
            this.txtSegundoOperador.Name = "txtSegundoOperador";
            this.txtSegundoOperador.Size = new System.Drawing.Size(158, 30);
            this.txtSegundoOperador.TabIndex = 2;
            this.txtSegundoOperador.TextChanged += new System.EventHandler(this.txtSegundoOperador_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(193, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Operación";
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox.BackColor = System.Drawing.Color.LightGray;
            this.groupBox.Controls.Add(this.rdbBinario);
            this.groupBox.Controls.Add(this.rdbDecimal);
            this.groupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox.Location = new System.Drawing.Point(115, 80);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(262, 65);
            this.groupBox.TabIndex = 6;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Representar resultado en:";
            // 
            // rdbBinario
            // 
            this.rdbBinario.AutoSize = true;
            this.rdbBinario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rdbBinario.Location = new System.Drawing.Point(150, 28);
            this.rdbBinario.Name = "rdbBinario";
            this.rdbBinario.Size = new System.Drawing.Size(57, 17);
            this.rdbBinario.TabIndex = 4;
            this.rdbBinario.TabStop = true;
            this.rdbBinario.Text = "Binario";
            this.rdbBinario.UseVisualStyleBackColor = false;
            this.rdbBinario.CheckedChanged += new System.EventHandler(this.rdbBinario_CheckedChanged);
            // 
            // rdbDecimal
            // 
            this.rdbDecimal.AutoSize = true;
            this.rdbDecimal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rdbDecimal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbDecimal.Location = new System.Drawing.Point(52, 28);
            this.rdbDecimal.Name = "rdbDecimal";
            this.rdbDecimal.Size = new System.Drawing.Size(63, 17);
            this.rdbDecimal.TabIndex = 3;
            this.rdbDecimal.TabStop = true;
            this.rdbDecimal.Text = "Decimal";
            this.rdbDecimal.UseVisualStyleBackColor = false;
            this.rdbDecimal.CheckedChanged += new System.EventHandler(this.rdbDecimal_CheckedChanged);
            // 
            // cmbOperacion
            // 
            this.cmbOperacion.BackColor = System.Drawing.SystemColors.Window;
            this.cmbOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbOperacion.ForeColor = System.Drawing.Color.Black;
            this.cmbOperacion.FormattingEnabled = true;
            this.cmbOperacion.Location = new System.Drawing.Point(191, 206);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(105, 32);
            this.cmbOperacion.TabIndex = 1;
            // 
            // btnOperar
            // 
            this.btnOperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperar.Location = new System.Drawing.Point(12, 243);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(156, 35);
            this.btnOperar.TabIndex = 3;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(320, 242);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(156, 35);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(191, 243);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(105, 35);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtPrimerOperador
            // 
            this.txtPrimerOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPrimerOperador.Location = new System.Drawing.Point(10, 206);
            this.txtPrimerOperador.Name = "txtPrimerOperador";
            this.txtPrimerOperador.Size = new System.Drawing.Size(158, 30);
            this.txtPrimerOperador.TabIndex = 0;

            // 
            // txtResultado
            // 
            this.txtResultado.AutoSize = true;
            this.txtResultado.BackColor = System.Drawing.Color.LightGray;
            this.txtResultado.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtResultado.Location = new System.Drawing.Point(252, 22);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(0, 31);
            this.txtResultado.TabIndex = 8;
            // 
            // lstHistorial
            // 
            this.lstHistorial.FormattingEnabled = true;
            this.lstHistorial.Location = new System.Drawing.Point(506, 67);
            this.lstHistorial.Name = "lstHistorial";
            this.lstHistorial.Size = new System.Drawing.Size(247, 212);
            this.lstHistorial.TabIndex = 9;
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.BackColor = System.Drawing.Color.LightGray;
            this.lblHistorial.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblHistorial.Location = new System.Drawing.Point(540, 22);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(159, 31);
            this.lblHistorial.TabIndex = 10;
            this.lblHistorial.Text = "HISTORIAL";
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(765, 291);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.lstHistorial);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtPrimerOperador);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.cmbOperacion);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSegundoOperador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Falcone Alejo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCalculadora_FormClosing);
            this.Load += new System.EventHandler(this.FrmCalculadora_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSegundoOperador;
        private TextBox txtPrimerOperador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ComboBox cmbOperacion;
        private System.Windows.Forms.RadioButton rdbDecimal;
        private System.Windows.Forms.RadioButton rdbBinario;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnLimpiar;
        private Label txtResultado;
        private ListBox lstHistorial;
        private Label lblHistorial;
    }
}

