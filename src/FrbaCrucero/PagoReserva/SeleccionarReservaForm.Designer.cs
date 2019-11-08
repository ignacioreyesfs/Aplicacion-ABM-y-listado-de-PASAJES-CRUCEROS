namespace FrbaCrucero.PagoReserva
{
    partial class SeleccionarReservaForm
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
            this.labelCodigoReserva = new System.Windows.Forms.Label();
            this.buttonSeleccionar = new System.Windows.Forms.Button();
            this.numericUpDownCodigo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCodigoReserva
            // 
            this.labelCodigoReserva.AutoSize = true;
            this.labelCodigoReserva.Location = new System.Drawing.Point(12, 15);
            this.labelCodigoReserva.Name = "labelCodigoReserva";
            this.labelCodigoReserva.Size = new System.Drawing.Size(83, 13);
            this.labelCodigoReserva.TabIndex = 0;
            this.labelCodigoReserva.Text = "Código Reserva";
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.Location = new System.Drawing.Point(101, 60);
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.buttonSeleccionar.TabIndex = 2;
            this.buttonSeleccionar.Text = "Seleccionar";
            this.buttonSeleccionar.UseVisualStyleBackColor = true;
            this.buttonSeleccionar.Click += new System.EventHandler(this.buttonSeleccionar_Click);
            // 
            // numericUpDownCodigo
            // 
            this.numericUpDownCodigo.Location = new System.Drawing.Point(101, 15);
            this.numericUpDownCodigo.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.numericUpDownCodigo.Name = "numericUpDownCodigo";
            this.numericUpDownCodigo.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCodigo.TabIndex = 3;
            // 
            // SeleccionarReservaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 95);
            this.Controls.Add(this.numericUpDownCodigo);
            this.Controls.Add(this.buttonSeleccionar);
            this.Controls.Add(this.labelCodigoReserva);
            this.Name = "SeleccionarReservaForm";
            this.Text = "Seleccionar Reserva";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCodigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodigoReserva;
        private System.Windows.Forms.Button buttonSeleccionar;
        private System.Windows.Forms.NumericUpDown numericUpDownCodigo;
    }
}