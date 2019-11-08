namespace FrbaCrucero.AbmCrucero
{
    partial class ListadoCrucerosForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.textBoxCrucero = new System.Windows.Forms.TextBox();
            this.labelCrucero = new System.Windows.Forms.Label();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.labelModelo = new System.Windows.Forms.Label();
            this.comboBoxServicio = new System.Windows.Forms.ComboBox();
            this.labelServicio = new System.Windows.Forms.Label();
            this.dataGridViewCrucero = new System.Windows.Forms.DataGridView();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrucero)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxEstado);
            this.groupBox1.Controls.Add(this.labelEstado);
            this.groupBox1.Controls.Add(this.textBoxCrucero);
            this.groupBox1.Controls.Add(this.labelCrucero);
            this.groupBox1.Controls.Add(this.textBoxModelo);
            this.groupBox1.Controls.Add(this.labelModelo);
            this.groupBox1.Controls.Add(this.comboBoxServicio);
            this.groupBox1.Controls.Add(this.labelServicio);
            this.groupBox1.Location = new System.Drawing.Point(16, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1061, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "",
            "En servicio",
            "Fuera de servicio"});
            this.comboBoxEstado.Location = new System.Drawing.Point(389, 31);
            this.comboBoxEstado.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(160, 24);
            this.comboBoxEstado.TabIndex = 7;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(328, 34);
            this.labelEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(52, 17);
            this.labelEstado.TabIndex = 4;
            this.labelEstado.Text = "Estado";
            // 
            // textBoxCrucero
            // 
            this.textBoxCrucero.Location = new System.Drawing.Point(84, 32);
            this.textBoxCrucero.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCrucero.Name = "textBoxCrucero";
            this.textBoxCrucero.Size = new System.Drawing.Size(132, 22);
            this.textBoxCrucero.TabIndex = 2;
            // 
            // labelCrucero
            // 
            this.labelCrucero.AutoSize = true;
            this.labelCrucero.Location = new System.Drawing.Point(17, 31);
            this.labelCrucero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCrucero.Name = "labelCrucero";
            this.labelCrucero.Size = new System.Drawing.Size(58, 17);
            this.labelCrucero.TabIndex = 1;
            this.labelCrucero.Text = "Crucero";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(84, 91);
            this.textBoxModelo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(132, 22);
            this.textBoxModelo.TabIndex = 2;
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(17, 90);
            this.labelModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(54, 17);
            this.labelModelo.TabIndex = 1;
            this.labelModelo.Text = "Modelo";
            // 
            // comboBoxServicio
            // 
            this.comboBoxServicio.FormattingEnabled = true;
            this.comboBoxServicio.Items.AddRange(new object[] {
            "",
            "Premium",
            "Estandar"});
            this.comboBoxServicio.Location = new System.Drawing.Point(389, 90);
            this.comboBoxServicio.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxServicio.Name = "comboBoxServicio";
            this.comboBoxServicio.Size = new System.Drawing.Size(160, 24);
            this.comboBoxServicio.TabIndex = 7;
            // 
            // labelServicio
            // 
            this.labelServicio.AutoSize = true;
            this.labelServicio.Location = new System.Drawing.Point(321, 94);
            this.labelServicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelServicio.Name = "labelServicio";
            this.labelServicio.Size = new System.Drawing.Size(58, 17);
            this.labelServicio.TabIndex = 1;
            this.labelServicio.Text = "Servicio";
            // 
            // dataGridViewCrucero
            // 
            this.dataGridViewCrucero.AllowUserToAddRows = false;
            this.dataGridViewCrucero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrucero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modificar,
            this.Eliminar});
            this.dataGridViewCrucero.Location = new System.Drawing.Point(16, 188);
            this.dataGridViewCrucero.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewCrucero.Name = "dataGridViewCrucero";
            this.dataGridViewCrucero.ReadOnly = true;
            this.dataGridViewCrucero.Size = new System.Drawing.Size(1061, 293);
            this.dataGridViewCrucero.TabIndex = 3;
            this.dataGridViewCrucero.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCrucero_CellContentClick);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(16, 153);
            this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(100, 28);
            this.buttonLimpiar.TabIndex = 5;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(977, 152);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(100, 28);
            this.buttonBuscar.TabIndex = 6;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(950, 488);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(127, 36);
            this.buttonAgregar.TabIndex = 7;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "";
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseColumnTextForButtonValue = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Dar de baja";
            this.Eliminar.UseColumnTextForButtonValue = true;
            // 
            // ListadoCrucerosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 529);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewCrucero);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonLimpiar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListadoCrucerosForm";
            this.Text = "ListadoCruceros";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrucero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxCrucero;
        private System.Windows.Forms.Label labelCrucero;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.ComboBox comboBoxServicio;
        private System.Windows.Forms.Label labelServicio;
        private System.Windows.Forms.DataGridView dataGridViewCrucero;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}