namespace FrbaCrucero.CompraReservaPasaje
{
    partial class SeleccionarPasajeros
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
            this.numericUpDownPasajeros = new System.Windows.Forms.NumericUpDown();
            this.labelPasajeros = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownPasajeros
            // 
            this.numericUpDownPasajeros.Location = new System.Drawing.Point(168, 58);
            this.numericUpDownPasajeros.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPasajeros.Name = "numericUpDownPasajeros";
            this.numericUpDownPasajeros.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownPasajeros.TabIndex = 0;
            this.numericUpDownPasajeros.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelPasajeros
            // 
            this.labelPasajeros.AutoSize = true;
            this.labelPasajeros.Location = new System.Drawing.Point(54, 60);
            this.labelPasajeros.Name = "labelPasajeros";
            this.labelPasajeros.Size = new System.Drawing.Size(108, 17);
            this.labelPasajeros.TabIndex = 1;
            this.labelPasajeros.Text = "Cant. Pasajeros";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(132, 132);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 2;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // SeleccionarPasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 193);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.labelPasajeros);
            this.Controls.Add(this.numericUpDownPasajeros);
            this.Name = "SeleccionarPasajeros";
            this.Text = "SeleccionarPasajeros";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPasajeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownPasajeros;
        private System.Windows.Forms.Label labelPasajeros;
        private System.Windows.Forms.Button buttonGuardar;
    }
}