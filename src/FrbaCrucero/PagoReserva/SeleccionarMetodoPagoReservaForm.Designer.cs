namespace FrbaCrucero.PagoReserva
{
    partial class SeleccionarMetodoPagoReservaForm
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
            this.groupBoxPago = new System.Windows.Forms.GroupBox();
            this.labelCuotas = new System.Windows.Forms.Label();
            this.numericUpDownCuotas = new System.Windows.Forms.NumericUpDown();
            this.comboBoxMetodoDePago = new System.Windows.Forms.ComboBox();
            this.labelMetodoDePago = new System.Windows.Forms.Label();
            this.buttonPagar = new System.Windows.Forms.Button();
            this.labelTotalAPagar = new System.Windows.Forms.Label();
            this.labelTotalAPagarInfo = new System.Windows.Forms.Label();
            this.groupBoxPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPago
            // 
            this.groupBoxPago.Controls.Add(this.labelCuotas);
            this.groupBoxPago.Controls.Add(this.numericUpDownCuotas);
            this.groupBoxPago.Controls.Add(this.comboBoxMetodoDePago);
            this.groupBoxPago.Controls.Add(this.labelMetodoDePago);
            this.groupBoxPago.Location = new System.Drawing.Point(12, 66);
            this.groupBoxPago.Name = "groupBoxPago";
            this.groupBoxPago.Size = new System.Drawing.Size(266, 100);
            this.groupBoxPago.TabIndex = 5;
            this.groupBoxPago.TabStop = false;
            this.groupBoxPago.Text = "Pago de reserva";
            // 
            // labelCuotas
            // 
            this.labelCuotas.AutoSize = true;
            this.labelCuotas.Location = new System.Drawing.Point(6, 57);
            this.labelCuotas.Name = "labelCuotas";
            this.labelCuotas.Size = new System.Drawing.Size(40, 13);
            this.labelCuotas.TabIndex = 1;
            this.labelCuotas.Text = "Cuotas";
            // 
            // numericUpDownCuotas
            // 
            this.numericUpDownCuotas.Location = new System.Drawing.Point(98, 55);
            this.numericUpDownCuotas.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownCuotas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCuotas.Name = "numericUpDownCuotas";
            this.numericUpDownCuotas.ReadOnly = true;
            this.numericUpDownCuotas.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCuotas.TabIndex = 3;
            this.numericUpDownCuotas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxMetodoDePago
            // 
            this.comboBoxMetodoDePago.FormattingEnabled = true;
            this.comboBoxMetodoDePago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de crédito",
            "Tarjeta de débito"});
            this.comboBoxMetodoDePago.Location = new System.Drawing.Point(98, 23);
            this.comboBoxMetodoDePago.Name = "comboBoxMetodoDePago";
            this.comboBoxMetodoDePago.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMetodoDePago.TabIndex = 2;
            this.comboBoxMetodoDePago.SelectedIndexChanged += new System.EventHandler(this.comboBoxMetodoDePago_SelectedIndexChanged);
            // 
            // labelMetodoDePago
            // 
            this.labelMetodoDePago.AutoSize = true;
            this.labelMetodoDePago.Location = new System.Drawing.Point(6, 26);
            this.labelMetodoDePago.Name = "labelMetodoDePago";
            this.labelMetodoDePago.Size = new System.Drawing.Size(85, 13);
            this.labelMetodoDePago.TabIndex = 0;
            this.labelMetodoDePago.Text = "Metodo de pago";
            // 
            // buttonPagar
            // 
            this.buttonPagar.Location = new System.Drawing.Point(203, 201);
            this.buttonPagar.Name = "buttonPagar";
            this.buttonPagar.Size = new System.Drawing.Size(75, 23);
            this.buttonPagar.TabIndex = 6;
            this.buttonPagar.Text = "Pagar";
            this.buttonPagar.UseVisualStyleBackColor = true;
            this.buttonPagar.Click += new System.EventHandler(this.buttonPagar_Click);
            // 
            // labelTotalAPagar
            // 
            this.labelTotalAPagar.AutoSize = true;
            this.labelTotalAPagar.Location = new System.Drawing.Point(9, 24);
            this.labelTotalAPagar.Name = "labelTotalAPagar";
            this.labelTotalAPagar.Size = new System.Drawing.Size(73, 13);
            this.labelTotalAPagar.TabIndex = 4;
            this.labelTotalAPagar.Text = "Total a pagar:";
            // 
            // labelTotalAPagarInfo
            // 
            this.labelTotalAPagarInfo.AutoSize = true;
            this.labelTotalAPagarInfo.Location = new System.Drawing.Point(88, 24);
            this.labelTotalAPagarInfo.Name = "labelTotalAPagarInfo";
            this.labelTotalAPagarInfo.Size = new System.Drawing.Size(106, 13);
            this.labelTotalAPagarInfo.TabIndex = 7;
            this.labelTotalAPagarInfo.Text = "labelTotalAPagarInfo";
            // 
            // SeleccionarMetodoPagoReservaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 236);
            this.Controls.Add(this.labelTotalAPagarInfo);
            this.Controls.Add(this.labelTotalAPagar);
            this.Controls.Add(this.buttonPagar);
            this.Controls.Add(this.groupBoxPago);
            this.Name = "SeleccionarMetodoPagoReservaForm";
            this.Text = "Seleccionar Método de Pago";
            this.groupBoxPago.ResumeLayout(false);
            this.groupBoxPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCuotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPago;
        private System.Windows.Forms.Label labelCuotas;
        private System.Windows.Forms.NumericUpDown numericUpDownCuotas;
        private System.Windows.Forms.ComboBox comboBoxMetodoDePago;
        private System.Windows.Forms.Label labelMetodoDePago;
        private System.Windows.Forms.Button buttonPagar;
        private System.Windows.Forms.Label labelTotalAPagar;
        private System.Windows.Forms.Label labelTotalAPagarInfo;
    }
}