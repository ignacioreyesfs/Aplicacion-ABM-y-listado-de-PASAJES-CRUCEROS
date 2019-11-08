namespace FrbaCrucero.CompraReservaPasaje
{
    partial class SeleccionarCompraOReserva
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
            this.labelCompraOReserva = new System.Windows.Forms.Label();
            this.buttonComprar = new System.Windows.Forms.Button();
            this.buttonReservar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCompraOReserva
            // 
            this.labelCompraOReserva.AutoSize = true;
            this.labelCompraOReserva.Location = new System.Drawing.Point(77, 46);
            this.labelCompraOReserva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCompraOReserva.Name = "labelCompraOReserva";
            this.labelCompraOReserva.Size = new System.Drawing.Size(234, 13);
            this.labelCompraOReserva.TabIndex = 0;
            this.labelCompraOReserva.Text = "¿Desea hacer una reserva o comprar el pasaje?";
            // 
            // buttonComprar
            // 
            this.buttonComprar.Location = new System.Drawing.Point(52, 98);
            this.buttonComprar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonComprar.Name = "buttonComprar";
            this.buttonComprar.Size = new System.Drawing.Size(82, 32);
            this.buttonComprar.TabIndex = 1;
            this.buttonComprar.Text = "Comprar";
            this.buttonComprar.UseVisualStyleBackColor = true;
            this.buttonComprar.Click += new System.EventHandler(this.buttonComprar_Click);
            // 
            // buttonReservar
            // 
            this.buttonReservar.Location = new System.Drawing.Point(256, 98);
            this.buttonReservar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReservar.Name = "buttonReservar";
            this.buttonReservar.Size = new System.Drawing.Size(82, 32);
            this.buttonReservar.TabIndex = 2;
            this.buttonReservar.Text = "Reservar";
            this.buttonReservar.UseVisualStyleBackColor = true;
            this.buttonReservar.Click += new System.EventHandler(this.buttonReservar_Click);
            // 
            // SeleccionarCompraOReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 160);
            this.Controls.Add(this.buttonReservar);
            this.Controls.Add(this.buttonComprar);
            this.Controls.Add(this.labelCompraOReserva);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SeleccionarCompraOReserva";
            this.Text = "SeleccionarCompraOReserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCompraOReserva;
        private System.Windows.Forms.Button buttonComprar;
        private System.Windows.Forms.Button buttonReservar;
    }
}