namespace FrbaCrucero.AbmCrucero
{
    partial class BajaDefinitiva
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelarPasajes = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Qué acción desea tomar con los pasajes que utilizan el crucero?";
            // 
            // buttonCancelarPasajes
            // 
            this.buttonCancelarPasajes.Location = new System.Drawing.Point(15, 56);
            this.buttonCancelarPasajes.Name = "buttonCancelarPasajes";
            this.buttonCancelarPasajes.Size = new System.Drawing.Size(119, 23);
            this.buttonCancelarPasajes.TabIndex = 1;
            this.buttonCancelarPasajes.Text = "Cancelar pasajes";
            this.buttonCancelarPasajes.UseVisualStyleBackColor = true;
            this.buttonCancelarPasajes.Click += new System.EventHandler(this.button_ClickCancelarPasajes);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cambiar de crucero";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BajaDefinitiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 92);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonCancelarPasajes);
            this.Controls.Add(this.label1);
            this.Name = "BajaDefinitiva";
            this.Text = "BajaDefinitiva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelarPasajes;
        private System.Windows.Forms.Button button2;
    }
}