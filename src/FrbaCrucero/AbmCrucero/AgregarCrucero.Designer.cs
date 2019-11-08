namespace FrbaCrucero.AbmCrucero
{
    partial class AgregarCrucero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelFabricante = new System.Windows.Forms.Label();
            this.labelTipoServicio = new System.Windows.Forms.Label();
            this.comboBoxTipoServicio = new System.Windows.Forms.ComboBox();
            this.numericUpDownCantidadCabinas = new System.Windows.Forms.NumericUpDown();
            this.labelCantidadCabinas = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxFabricante = new System.Windows.Forms.TextBox();
            this.buttonSeleccionarFabricante = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidadCabinas)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(153, 37);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(117, 22);
            this.textBoxNombre.TabIndex = 0;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(153, 65);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(117, 22);
            this.textBoxModelo.TabIndex = 1;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(12, 37);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(58, 17);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(13, 65);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(54, 17);
            this.labelModelo.TabIndex = 3;
            this.labelModelo.Text = "Modelo";
            // 
            // labelFabricante
            // 
            this.labelFabricante.AutoSize = true;
            this.labelFabricante.Location = new System.Drawing.Point(12, 93);
            this.labelFabricante.Name = "labelFabricante";
            this.labelFabricante.Size = new System.Drawing.Size(75, 17);
            this.labelFabricante.TabIndex = 4;
            this.labelFabricante.Text = "Fabricante";
            // 
            // labelTipoServicio
            // 
            this.labelTipoServicio.AutoSize = true;
            this.labelTipoServicio.Location = new System.Drawing.Point(12, 121);
            this.labelTipoServicio.Name = "labelTipoServicio";
            this.labelTipoServicio.Size = new System.Drawing.Size(108, 17);
            this.labelTipoServicio.TabIndex = 9;
            this.labelTipoServicio.Text = "Tipo de servicio";
            // 
            // comboBoxTipoServicio
            // 
            this.comboBoxTipoServicio.FormattingEnabled = true;
            this.comboBoxTipoServicio.Items.AddRange(new object[] {
            "Estandar",
            "All-inclusive"});
            this.comboBoxTipoServicio.Location = new System.Drawing.Point(153, 121);
            this.comboBoxTipoServicio.Name = "comboBoxTipoServicio";
            this.comboBoxTipoServicio.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTipoServicio.TabIndex = 10;
            // 
            // numericUpDownCantidadCabinas
            // 
            this.numericUpDownCantidadCabinas.Location = new System.Drawing.Point(153, 151);
            this.numericUpDownCantidadCabinas.Name = "numericUpDownCantidadCabinas";
            this.numericUpDownCantidadCabinas.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCantidadCabinas.TabIndex = 11;
            // 
            // labelCantidadCabinas
            // 
            this.labelCantidadCabinas.AutoSize = true;
            this.labelCantidadCabinas.Location = new System.Drawing.Point(12, 151);
            this.labelCantidadCabinas.Name = "labelCantidadCabinas";
            this.labelCantidadCabinas.Size = new System.Drawing.Size(137, 17);
            this.labelCantidadCabinas.TabIndex = 12;
            this.labelCantidadCabinas.Text = "Cantidad de cabinas";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(292, 197);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(82, 23);
            this.buttonGuardar.TabIndex = 13;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(103, 197);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(82, 23);
            this.buttonCancelar.TabIndex = 14;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxFabricante
            // 
            this.textBoxFabricante.Location = new System.Drawing.Point(153, 93);
            this.textBoxFabricante.Name = "textBoxFabricante";
            this.textBoxFabricante.Size = new System.Drawing.Size(117, 22);
            this.textBoxFabricante.TabIndex = 5;
            // 
            // buttonSeleccionarFabricante
            // 
            this.buttonSeleccionarFabricante.Location = new System.Drawing.Point(276, 93);
            this.buttonSeleccionarFabricante.Name = "buttonSeleccionarFabricante";
            this.buttonSeleccionarFabricante.Size = new System.Drawing.Size(98, 23);
            this.buttonSeleccionarFabricante.TabIndex = 6;
            this.buttonSeleccionarFabricante.Text = "Seleccionar";
            this.buttonSeleccionarFabricante.UseVisualStyleBackColor = true;
            this.buttonSeleccionarFabricante.Click += new System.EventHandler(this.buttonSeleccionarFabricante_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(16, 197);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(81, 23);
            this.buttonLimpiar.TabIndex = 15;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // AgregarCrucero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 243);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.labelCantidadCabinas);
            this.Controls.Add(this.numericUpDownCantidadCabinas);
            this.Controls.Add(this.comboBoxTipoServicio);
            this.Controls.Add(this.labelTipoServicio);
            this.Controls.Add(this.buttonSeleccionarFabricante);
            this.Controls.Add(this.textBoxFabricante);
            this.Controls.Add(this.labelFabricante);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.textBoxNombre);
            this.Name = "AgregarCrucero";
            this.Text = "AgregarCrucero";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidadCabinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelFabricante;
        private System.Windows.Forms.Label labelTipoServicio;
        private System.Windows.Forms.ComboBox comboBoxTipoServicio;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidadCabinas;
        private System.Windows.Forms.Label labelCantidadCabinas;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxFabricante;
        private System.Windows.Forms.Button buttonSeleccionarFabricante;
        private System.Windows.Forms.Button buttonLimpiar;
    }
}