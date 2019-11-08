namespace FrbaCrucero.GeneracionViaje
{
    partial class FormGenerarViaje
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
            this.textBoxCrucero = new System.Windows.Forms.TextBox();
            this.textBoxFechaInicio = new System.Windows.Forms.TextBox();
            this.labelCrucero = new System.Windows.Forms.Label();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.labelFechaFin = new System.Windows.Forms.Label();
            this.textBoxFechaFin = new System.Windows.Forms.TextBox();
            this.buttonSeleccionarCrucero = new System.Windows.Forms.Button();
            this.buttonSeleccionarPuertoHasta = new System.Windows.Forms.Button();
            this.buttonSeleccionarFechaInicio = new System.Windows.Forms.Button();
            this.buttonSeleccionarFechaFin = new System.Windows.Forms.Button();
            this.buttonGenerarViaje = new System.Windows.Forms.Button();
            this.textBoxIDRecorrido = new System.Windows.Forms.TextBox();
            this.labelRecorrido = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCrucero
            // 
            this.textBoxCrucero.Location = new System.Drawing.Point(151, 41);
            this.textBoxCrucero.Name = "textBoxCrucero";
            this.textBoxCrucero.Size = new System.Drawing.Size(100, 22);
            this.textBoxCrucero.TabIndex = 0;
            this.textBoxCrucero.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxFechaInicio
            // 
            this.textBoxFechaInicio.Location = new System.Drawing.Point(151, 116);
            this.textBoxFechaInicio.Name = "textBoxFechaInicio";
            this.textBoxFechaInicio.Size = new System.Drawing.Size(100, 22);
            this.textBoxFechaInicio.TabIndex = 3;
            // 
            // labelCrucero
            // 
            this.labelCrucero.AutoSize = true;
            this.labelCrucero.Location = new System.Drawing.Point(45, 40);
            this.labelCrucero.Name = "labelCrucero";
            this.labelCrucero.Size = new System.Drawing.Size(73, 17);
            this.labelCrucero.TabIndex = 4;
            this.labelCrucero.Text = "ID crucero";
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Location = new System.Drawing.Point(45, 115);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(83, 17);
            this.labelFechaInicio.TabIndex = 7;
            this.labelFechaInicio.Text = "Fecha inicio";
            // 
            // labelFechaFin
            // 
            this.labelFechaFin.AutoSize = true;
            this.labelFechaFin.Location = new System.Drawing.Point(45, 154);
            this.labelFechaFin.Name = "labelFechaFin";
            this.labelFechaFin.Size = new System.Drawing.Size(66, 17);
            this.labelFechaFin.TabIndex = 8;
            this.labelFechaFin.Text = "Fecha fin";
            // 
            // textBoxFechaFin
            // 
            this.textBoxFechaFin.Location = new System.Drawing.Point(151, 154);
            this.textBoxFechaFin.Name = "textBoxFechaFin";
            this.textBoxFechaFin.Size = new System.Drawing.Size(100, 22);
            this.textBoxFechaFin.TabIndex = 9;
            // 
            // buttonSeleccionarCrucero
            // 
            this.buttonSeleccionarCrucero.Location = new System.Drawing.Point(275, 40);
            this.buttonSeleccionarCrucero.Name = "buttonSeleccionarCrucero";
            this.buttonSeleccionarCrucero.Size = new System.Drawing.Size(96, 23);
            this.buttonSeleccionarCrucero.TabIndex = 10;
            this.buttonSeleccionarCrucero.Text = "Seleccionar";
            this.buttonSeleccionarCrucero.UseVisualStyleBackColor = true;
            this.buttonSeleccionarCrucero.Click += new System.EventHandler(this.buttonSeleccionarCrucero_Click);
            // 
            // buttonSeleccionarPuertoHasta
            // 
            this.buttonSeleccionarPuertoHasta.Location = new System.Drawing.Point(275, 74);
            this.buttonSeleccionarPuertoHasta.Name = "buttonSeleccionarPuertoHasta";
            this.buttonSeleccionarPuertoHasta.Size = new System.Drawing.Size(96, 23);
            this.buttonSeleccionarPuertoHasta.TabIndex = 12;
            this.buttonSeleccionarPuertoHasta.Text = "Seleccionar";
            this.buttonSeleccionarPuertoHasta.UseVisualStyleBackColor = true;
            this.buttonSeleccionarPuertoHasta.Click += new System.EventHandler(this.buttonSeleccionarPuertoHasta_Click);
            // 
            // buttonSeleccionarFechaInicio
            // 
            this.buttonSeleccionarFechaInicio.Location = new System.Drawing.Point(275, 115);
            this.buttonSeleccionarFechaInicio.Name = "buttonSeleccionarFechaInicio";
            this.buttonSeleccionarFechaInicio.Size = new System.Drawing.Size(96, 23);
            this.buttonSeleccionarFechaInicio.TabIndex = 13;
            this.buttonSeleccionarFechaInicio.Text = "Seleccionar";
            this.buttonSeleccionarFechaInicio.UseVisualStyleBackColor = true;
            this.buttonSeleccionarFechaInicio.Click += new System.EventHandler(this.buttonSeleccionarFechaInicio_Click);
            // 
            // buttonSeleccionarFechaFin
            // 
            this.buttonSeleccionarFechaFin.Location = new System.Drawing.Point(275, 154);
            this.buttonSeleccionarFechaFin.Name = "buttonSeleccionarFechaFin";
            this.buttonSeleccionarFechaFin.Size = new System.Drawing.Size(96, 23);
            this.buttonSeleccionarFechaFin.TabIndex = 14;
            this.buttonSeleccionarFechaFin.Text = "Seleccionar";
            this.buttonSeleccionarFechaFin.UseVisualStyleBackColor = true;
            this.buttonSeleccionarFechaFin.Click += new System.EventHandler(this.buttonSeleccionarFechaFin_Click);
            // 
            // buttonGenerarViaje
            // 
            this.buttonGenerarViaje.Location = new System.Drawing.Point(422, 74);
            this.buttonGenerarViaje.Name = "buttonGenerarViaje";
            this.buttonGenerarViaje.Size = new System.Drawing.Size(103, 82);
            this.buttonGenerarViaje.TabIndex = 15;
            this.buttonGenerarViaje.Text = "Generar";
            this.buttonGenerarViaje.UseVisualStyleBackColor = true;
            this.buttonGenerarViaje.Click += new System.EventHandler(this.buttonGenerarViaje_Click);
            // 
            // textBoxIDRecorrido
            // 
            this.textBoxIDRecorrido.Location = new System.Drawing.Point(151, 74);
            this.textBoxIDRecorrido.Name = "textBoxIDRecorrido";
            this.textBoxIDRecorrido.Size = new System.Drawing.Size(100, 22);
            this.textBoxIDRecorrido.TabIndex = 17;
            // 
            // labelRecorrido
            // 
            this.labelRecorrido.AutoSize = true;
            this.labelRecorrido.Location = new System.Drawing.Point(45, 74);
            this.labelRecorrido.Name = "labelRecorrido";
            this.labelRecorrido.Size = new System.Drawing.Size(82, 17);
            this.labelRecorrido.TabIndex = 18;
            this.labelRecorrido.Text = "ID recorrido";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(43, 197);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(84, 23);
            this.buttonCancelar.TabIndex = 19;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(133, 197);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(84, 23);
            this.buttonLimpiar.TabIndex = 20;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // FormGenerarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 243);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.labelRecorrido);
            this.Controls.Add(this.textBoxIDRecorrido);
            this.Controls.Add(this.buttonGenerarViaje);
            this.Controls.Add(this.buttonSeleccionarFechaFin);
            this.Controls.Add(this.buttonSeleccionarFechaInicio);
            this.Controls.Add(this.buttonSeleccionarPuertoHasta);
            this.Controls.Add(this.buttonSeleccionarCrucero);
            this.Controls.Add(this.textBoxFechaFin);
            this.Controls.Add(this.labelFechaFin);
            this.Controls.Add(this.labelFechaInicio);
            this.Controls.Add(this.labelCrucero);
            this.Controls.Add(this.textBoxFechaInicio);
            this.Controls.Add(this.textBoxCrucero);
            this.Name = "FormGenerarViaje";
            this.Text = "Generar Viaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCrucero;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Label labelFechaFin;
        private System.Windows.Forms.TextBox textBoxFechaFin;
        private System.Windows.Forms.Button buttonSeleccionarCrucero;
        private System.Windows.Forms.Button buttonSeleccionarPuertoHasta;
        private System.Windows.Forms.Button buttonSeleccionarFechaInicio;
        private System.Windows.Forms.Button buttonSeleccionarFechaFin;
        private System.Windows.Forms.Button buttonGenerarViaje;
        public System.Windows.Forms.TextBox textBoxFechaInicio;
        private System.Windows.Forms.Label labelRecorrido;
        private System.Windows.Forms.Button buttonCancelar;
        public System.Windows.Forms.TextBox textBoxCrucero;
        public System.Windows.Forms.TextBox textBoxIDRecorrido;
        private System.Windows.Forms.Button buttonLimpiar;
    }
}