namespace FrbaCrucero.GeneracionViaje
{
    partial class SeleccionarFecha
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
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.buttonSeleccionarFecha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(0, 0);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(282, 22);
            this.dateTimePickerFecha.TabIndex = 0;
            // 
            // buttonSeleccionarFecha
            // 
            this.buttonSeleccionarFecha.Location = new System.Drawing.Point(92, 56);
            this.buttonSeleccionarFecha.Name = "buttonSeleccionarFecha";
            this.buttonSeleccionarFecha.Size = new System.Drawing.Size(97, 33);
            this.buttonSeleccionarFecha.TabIndex = 1;
            this.buttonSeleccionarFecha.Text = "Guardar";
            this.buttonSeleccionarFecha.UseVisualStyleBackColor = true;
            this.buttonSeleccionarFecha.Click += new System.EventHandler(this.buttonSeleccionarFecha_Click);
            // 
            // SeleccionarFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 101);
            this.Controls.Add(this.buttonSeleccionarFecha);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Name = "SeleccionarFecha";
            this.Text = "Seleccionar Fecha";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Button buttonSeleccionarFecha;
    }
}