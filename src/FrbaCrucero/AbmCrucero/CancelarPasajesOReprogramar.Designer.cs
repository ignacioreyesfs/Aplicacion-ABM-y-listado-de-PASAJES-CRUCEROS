namespace FrbaCrucero.AbmCrucero
{
    partial class CancelarPasajesOReprogramar
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
            this.Mensaje1 = new System.Windows.Forms.Label();
            this.Mensaje2 = new System.Windows.Forms.Label();
            this.buttonCancelarPasajes = new System.Windows.Forms.Button();
            this.buttonReprogramarViajes = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mensaje1
            // 
            this.Mensaje1.AutoSize = true;
            this.Mensaje1.Location = new System.Drawing.Point(12, 25);
            this.Mensaje1.Name = "Mensaje1";
            this.Mensaje1.Size = new System.Drawing.Size(614, 17);
            this.Mensaje1.TabIndex = 0;
            this.Mensaje1.Text = "Se ha detectado que quiere dar de baja el servicio momentaneamente del crucero se" +
    "leccionado";
            // 
            // Mensaje2
            // 
            this.Mensaje2.AutoSize = true;
            this.Mensaje2.Location = new System.Drawing.Point(12, 56);
            this.Mensaje2.Name = "Mensaje2";
            this.Mensaje2.Size = new System.Drawing.Size(423, 17);
            this.Mensaje2.TabIndex = 1;
            this.Mensaje2.Text = "Quiere cancelar los pasajes o reprogramar los viajes pendientes?";
            // 
            // buttonCancelarPasajes
            // 
            this.buttonCancelarPasajes.Location = new System.Drawing.Point(344, 110);
            this.buttonCancelarPasajes.Name = "buttonCancelarPasajes";
            this.buttonCancelarPasajes.Size = new System.Drawing.Size(138, 47);
            this.buttonCancelarPasajes.TabIndex = 2;
            this.buttonCancelarPasajes.Text = "Cancelar pasajes";
            this.buttonCancelarPasajes.UseVisualStyleBackColor = true;
            this.buttonCancelarPasajes.Click += new System.EventHandler(this.buttonCancelarPasajes_Click);
            // 
            // buttonReprogramarViajes
            // 
            this.buttonReprogramarViajes.Location = new System.Drawing.Point(488, 110);
            this.buttonReprogramarViajes.Name = "buttonReprogramarViajes";
            this.buttonReprogramarViajes.Size = new System.Drawing.Size(138, 47);
            this.buttonReprogramarViajes.TabIndex = 3;
            this.buttonReprogramarViajes.Text = "Reprogramar viajes";
            this.buttonReprogramarViajes.UseVisualStyleBackColor = true;
            this.buttonReprogramarViajes.Click += new System.EventHandler(this.buttonReprogramarViajes_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(15, 110);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(97, 47);
            this.buttonVolver.TabIndex = 4;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            // 
            // CancelarPasajesOReprogramar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 181);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonReprogramarViajes);
            this.Controls.Add(this.buttonCancelarPasajes);
            this.Controls.Add(this.Mensaje2);
            this.Controls.Add(this.Mensaje1);
            this.Name = "CancelarPasajesOReprogramar";
            this.Text = "Cancelar o Reprogramar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mensaje1;
        private System.Windows.Forms.Label Mensaje2;
        private System.Windows.Forms.Button buttonCancelarPasajes;
        private System.Windows.Forms.Button buttonReprogramarViajes;
        private System.Windows.Forms.Button buttonVolver;
    }
}