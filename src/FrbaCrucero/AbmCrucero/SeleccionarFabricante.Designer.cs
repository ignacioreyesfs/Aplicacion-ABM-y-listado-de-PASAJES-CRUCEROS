namespace FrbaCrucero.AbmCrucero
{
    partial class SeleccionarFabricante
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
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxFabricante = new System.Windows.Forms.TextBox();
            this.dataGridViewFabricantes = new System.Windows.Forms.DataGridView();
            this.groupBoxFiltroFabricante = new System.Windows.Forms.GroupBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFabricantes)).BeginInit();
            this.groupBoxFiltroFabricante.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(18, 49);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(82, 17);
            this.labelDescripcion.TabIndex = 0;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // textBoxFabricante
            // 
            this.textBoxFabricante.Location = new System.Drawing.Point(106, 49);
            this.textBoxFabricante.Name = "textBoxFabricante";
            this.textBoxFabricante.Size = new System.Drawing.Size(184, 22);
            this.textBoxFabricante.TabIndex = 1;
            // 
            // dataGridViewFabricantes
            // 
            this.dataGridViewFabricantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFabricantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dataGridViewFabricantes.Location = new System.Drawing.Point(12, 163);
            this.dataGridViewFabricantes.Name = "dataGridViewFabricantes";
            this.dataGridViewFabricantes.RowTemplate.Height = 24;
            this.dataGridViewFabricantes.Size = new System.Drawing.Size(476, 332);
            this.dataGridViewFabricantes.TabIndex = 2;
            this.dataGridViewFabricantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFabricantes_CellContentClick);
            // 
            // groupBoxFiltroFabricante
            // 
            this.groupBoxFiltroFabricante.Controls.Add(this.labelDescripcion);
            this.groupBoxFiltroFabricante.Controls.Add(this.textBoxFabricante);
            this.groupBoxFiltroFabricante.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFiltroFabricante.Name = "groupBoxFiltroFabricante";
            this.groupBoxFiltroFabricante.Size = new System.Drawing.Size(476, 101);
            this.groupBoxFiltroFabricante.TabIndex = 3;
            this.groupBoxFiltroFabricante.TabStop = false;
            this.groupBoxFiltroFabricante.Text = "Filtrar fabricante";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(21, 119);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(91, 38);
            this.buttonLimpiar.TabIndex = 4;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(397, 120);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(91, 37);
            this.buttonBuscar.TabIndex = 5;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Text = "Seleccionar";
            this.Seleccionar.UseColumnTextForButtonValue = true;
            // 
            // SeleccionarFabricante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 507);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.groupBoxFiltroFabricante);
            this.Controls.Add(this.dataGridViewFabricantes);
            this.Name = "SeleccionarFabricante";
            this.Text = "Seleccionar Fabricante";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFabricantes)).EndInit();
            this.groupBoxFiltroFabricante.ResumeLayout(false);
            this.groupBoxFiltroFabricante.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textBoxFabricante;
        private System.Windows.Forms.DataGridView dataGridViewFabricantes;
        private System.Windows.Forms.GroupBox groupBoxFiltroFabricante;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
    }
}