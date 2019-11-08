namespace FrbaCrucero.CompraReservaPasaje
{
    partial class SeleccionarCabina
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
            this.dataGridViewCabinas = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCabinas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCabinas
            // 
            this.dataGridViewCabinas.AllowUserToAddRows = false;
            this.dataGridViewCabinas.AllowUserToDeleteRows = false;
            this.dataGridViewCabinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCabinas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dataGridViewCabinas.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewCabinas.Name = "dataGridViewCabinas";
            this.dataGridViewCabinas.ReadOnly = true;
            this.dataGridViewCabinas.RowTemplate.Height = 24;
            this.dataGridViewCabinas.Size = new System.Drawing.Size(532, 502);
            this.dataGridViewCabinas.TabIndex = 0;
            this.dataGridViewCabinas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCabinas_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Text = "Seleccionar";
            this.Seleccionar.UseColumnTextForButtonValue = true;
            // 
            // SeleccionarCabina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 526);
            this.Controls.Add(this.dataGridViewCabinas);
            this.Name = "SeleccionarCabina";
            this.Text = "SeleccionarCabina";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCabinas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCabinas;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
    }
}