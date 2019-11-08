namespace FrbaCrucero.PagoReserva
{
    partial class ReservaForm
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
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelCodigoInfo = new System.Windows.Forms.Label();
            this.labelCantPasajes = new System.Windows.Forms.Label();
            this.labelCantPasajInfo = new System.Windows.Forms.Label();
            this.labelMonto = new System.Windows.Forms.Label();
            this.labelMontoInfo = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelClienteInfo = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(12, 9);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(43, 13);
            this.labelCodigo.TabIndex = 0;
            this.labelCodigo.Text = "Codigo:";
            // 
            // labelCodigoInfo
            // 
            this.labelCodigoInfo.AutoSize = true;
            this.labelCodigoInfo.Location = new System.Drawing.Point(61, 9);
            this.labelCodigoInfo.Name = "labelCodigoInfo";
            this.labelCodigoInfo.Size = new System.Drawing.Size(80, 13);
            this.labelCodigoInfo.TabIndex = 1;
            this.labelCodigoInfo.Text = "labelCodigoInfo";
            // 
            // labelCantPasajes
            // 
            this.labelCantPasajes.AutoSize = true;
            this.labelCantPasajes.Location = new System.Drawing.Point(12, 32);
            this.labelCantPasajes.Name = "labelCantPasajes";
            this.labelCantPasajes.Size = new System.Drawing.Size(95, 13);
            this.labelCantPasajes.TabIndex = 2;
            this.labelCantPasajes.Text = "Cantidad Pasajes: ";
            // 
            // labelCantPasajInfo
            // 
            this.labelCantPasajInfo.AutoSize = true;
            this.labelCantPasajInfo.Location = new System.Drawing.Point(113, 32);
            this.labelCantPasajInfo.Name = "labelCantPasajInfo";
            this.labelCantPasajInfo.Size = new System.Drawing.Size(95, 13);
            this.labelCantPasajInfo.TabIndex = 3;
            this.labelCantPasajInfo.Text = "labelCantPasajInfo";
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Location = new System.Drawing.Point(12, 58);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(40, 13);
            this.labelMonto.TabIndex = 4;
            this.labelMonto.Text = "Monto:";
            // 
            // labelMontoInfo
            // 
            this.labelMontoInfo.AutoSize = true;
            this.labelMontoInfo.Location = new System.Drawing.Point(58, 58);
            this.labelMontoInfo.Name = "labelMontoInfo";
            this.labelMontoInfo.Size = new System.Drawing.Size(77, 13);
            this.labelMontoInfo.TabIndex = 5;
            this.labelMontoInfo.Text = "labelMontoInfo";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(12, 89);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(42, 13);
            this.labelCliente.TabIndex = 6;
            this.labelCliente.Text = "Cliente:";
            // 
            // labelClienteInfo
            // 
            this.labelClienteInfo.AutoSize = true;
            this.labelClienteInfo.Location = new System.Drawing.Point(60, 89);
            this.labelClienteInfo.Name = "labelClienteInfo";
            this.labelClienteInfo.Size = new System.Drawing.Size(79, 13);
            this.labelClienteInfo.TabIndex = 7;
            this.labelClienteInfo.Text = "labelClienteInfo";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(12, 154);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(197, 154);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 9;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // ReservaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 194);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.labelClienteInfo);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.labelMontoInfo);
            this.Controls.Add(this.labelMonto);
            this.Controls.Add(this.labelCantPasajInfo);
            this.Controls.Add(this.labelCantPasajes);
            this.Controls.Add(this.labelCodigoInfo);
            this.Controls.Add(this.labelCodigo);
            this.Name = "ReservaForm";
            this.Text = "Validar Reserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelCodigoInfo;
        private System.Windows.Forms.Label labelCantPasajes;
        private System.Windows.Forms.Label labelCantPasajInfo;
        private System.Windows.Forms.Label labelMonto;
        private System.Windows.Forms.Label labelMontoInfo;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelClienteInfo;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
    }
}