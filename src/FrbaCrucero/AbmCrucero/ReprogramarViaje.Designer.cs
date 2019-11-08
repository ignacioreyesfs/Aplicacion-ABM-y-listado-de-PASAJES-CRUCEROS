namespace FrbaCrucero.AbmCrucero
{
    partial class ReprogramarViaje
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
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.labelDias = new System.Windows.Forms.Label();
            this.numericUpDownDias = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDias)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(300, 109);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(105, 42);
            this.buttonGuardar.TabIndex = 0;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(12, 109);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(105, 42);
            this.buttonVolver.TabIndex = 1;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            // 
            // labelDias
            // 
            this.labelDias.AutoSize = true;
            this.labelDias.Location = new System.Drawing.Point(27, 51);
            this.labelDias.Name = "labelDias";
            this.labelDias.Size = new System.Drawing.Size(130, 17);
            this.labelDias.TabIndex = 2;
            this.labelDias.Text = "Dias de corrimiento";
            // 
            // numericUpDownDias
            // 
            this.numericUpDownDias.Location = new System.Drawing.Point(164, 51);
            this.numericUpDownDias.Name = "numericUpDownDias";
            this.numericUpDownDias.Size = new System.Drawing.Size(156, 22);
            this.numericUpDownDias.TabIndex = 3;
            // 
            // ReprogramarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 163);
            this.Controls.Add(this.numericUpDownDias);
            this.Controls.Add(this.labelDias);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonGuardar);
            this.Name = "ReprogramarViaje";
            this.Text = "Reprogramar viaje";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Label labelDias;
        private System.Windows.Forms.NumericUpDown numericUpDownDias;
    }
}