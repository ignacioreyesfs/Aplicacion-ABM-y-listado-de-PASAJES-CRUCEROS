namespace FrbaCrucero.AbmRecorrido
{
    partial class ListadoRecorridoForm
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
            this.labelHabilitado = new System.Windows.Forms.Label();
            this.comboBoxHabilitado = new System.Windows.Forms.ComboBox();
            this.labelPuertoDesde = new System.Windows.Forms.Label();
            this.labelPuertoHasta = new System.Windows.Forms.Label();
            this.textBoxPuertoDesde = new System.Windows.Forms.TextBox();
            this.buttonSeleccionarDesde = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.textBoxPuertoHasta = new System.Windows.Forms.TextBox();
            this.groupBoxFiltrosRecorrido = new System.Windows.Forms.GroupBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dataGridViewRecorrido = new System.Windows.Forms.DataGridView();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BajaRecorrido = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBoxFiltrosRecorrido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecorrido)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHabilitado
            // 
            this.labelHabilitado.AutoSize = true;
            this.labelHabilitado.Location = new System.Drawing.Point(16, 41);
            this.labelHabilitado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHabilitado.Name = "labelHabilitado";
            this.labelHabilitado.Size = new System.Drawing.Size(71, 17);
            this.labelHabilitado.TabIndex = 0;
            this.labelHabilitado.Text = "Habilitado";
            // 
            // comboBoxHabilitado
            // 
            this.comboBoxHabilitado.FormattingEnabled = true;
            this.comboBoxHabilitado.Items.AddRange(new object[] {
            "Todos",
            "Si",
            "No"});
            this.comboBoxHabilitado.Location = new System.Drawing.Point(136, 37);
            this.comboBoxHabilitado.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxHabilitado.Name = "comboBoxHabilitado";
            this.comboBoxHabilitado.Size = new System.Drawing.Size(160, 24);
            this.comboBoxHabilitado.TabIndex = 1;
            // 
            // labelPuertoDesde
            // 
            this.labelPuertoDesde.AutoSize = true;
            this.labelPuertoDesde.Location = new System.Drawing.Point(16, 84);
            this.labelPuertoDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPuertoDesde.Name = "labelPuertoDesde";
            this.labelPuertoDesde.Size = new System.Drawing.Size(110, 17);
            this.labelPuertoDesde.TabIndex = 2;
            this.labelPuertoDesde.Text = "ID Puerto desde";
            // 
            // labelPuertoHasta
            // 
            this.labelPuertoHasta.AutoSize = true;
            this.labelPuertoHasta.Location = new System.Drawing.Point(16, 130);
            this.labelPuertoHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPuertoHasta.Name = "labelPuertoHasta";
            this.labelPuertoHasta.Size = new System.Drawing.Size(106, 17);
            this.labelPuertoHasta.TabIndex = 4;
            this.labelPuertoHasta.Text = "ID Puerto hasta";
            // 
            // textBoxPuertoDesde
            // 
            this.textBoxPuertoDesde.Location = new System.Drawing.Point(136, 80);
            this.textBoxPuertoDesde.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPuertoDesde.Name = "textBoxPuertoDesde";
            this.textBoxPuertoDesde.Size = new System.Drawing.Size(132, 22);
            this.textBoxPuertoDesde.TabIndex = 5;
            // 
            // buttonSeleccionarDesde
            // 
            this.buttonSeleccionarDesde.Location = new System.Drawing.Point(293, 78);
            this.buttonSeleccionarDesde.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSeleccionarDesde.Name = "buttonSeleccionarDesde";
            this.buttonSeleccionarDesde.Size = new System.Drawing.Size(100, 28);
            this.buttonSeleccionarDesde.TabIndex = 6;
            this.buttonSeleccionarDesde.Text = "Seleccionar";
            this.buttonSeleccionarDesde.UseVisualStyleBackColor = true;
            this.buttonSeleccionarDesde.Click += new System.EventHandler(this.buttonSeleccionarDesde_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 124);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(589, 475);
            this.buttonAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(133, 49);
            this.buttonAgregar.TabIndex = 13;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // textBoxPuertoHasta
            // 
            this.textBoxPuertoHasta.Location = new System.Drawing.Point(136, 127);
            this.textBoxPuertoHasta.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPuertoHasta.Name = "textBoxPuertoHasta";
            this.textBoxPuertoHasta.Size = new System.Drawing.Size(132, 22);
            this.textBoxPuertoHasta.TabIndex = 8;
            // 
            // groupBoxFiltrosRecorrido
            // 
            this.groupBoxFiltrosRecorrido.Controls.Add(this.labelPuertoDesde);
            this.groupBoxFiltrosRecorrido.Controls.Add(this.textBoxPuertoHasta);
            this.groupBoxFiltrosRecorrido.Controls.Add(this.labelHabilitado);
            this.groupBoxFiltrosRecorrido.Controls.Add(this.button1);
            this.groupBoxFiltrosRecorrido.Controls.Add(this.comboBoxHabilitado);
            this.groupBoxFiltrosRecorrido.Controls.Add(this.buttonSeleccionarDesde);
            this.groupBoxFiltrosRecorrido.Controls.Add(this.labelPuertoHasta);
            this.groupBoxFiltrosRecorrido.Controls.Add(this.textBoxPuertoDesde);
            this.groupBoxFiltrosRecorrido.Location = new System.Drawing.Point(16, 15);
            this.groupBoxFiltrosRecorrido.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxFiltrosRecorrido.Name = "groupBoxFiltrosRecorrido";
            this.groupBoxFiltrosRecorrido.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxFiltrosRecorrido.Size = new System.Drawing.Size(707, 176);
            this.groupBoxFiltrosRecorrido.TabIndex = 9;
            this.groupBoxFiltrosRecorrido.TabStop = false;
            this.groupBoxFiltrosRecorrido.Text = "Filtros Recorrido";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(16, 198);
            this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(100, 28);
            this.buttonLimpiar.TabIndex = 10;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(623, 198);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(100, 28);
            this.buttonBuscar.TabIndex = 11;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // dataGridViewRecorrido
            // 
            this.dataGridViewRecorrido.AllowUserToAddRows = false;
            this.dataGridViewRecorrido.AllowUserToDeleteRows = false;
            this.dataGridViewRecorrido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecorrido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modificar,
            this.BajaRecorrido});
            this.dataGridViewRecorrido.Location = new System.Drawing.Point(16, 234);
            this.dataGridViewRecorrido.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewRecorrido.Name = "dataGridViewRecorrido";
            this.dataGridViewRecorrido.ReadOnly = true;
            this.dataGridViewRecorrido.Size = new System.Drawing.Size(707, 234);
            this.dataGridViewRecorrido.TabIndex = 12;
            this.dataGridViewRecorrido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecorrido_CellContentClick);
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "";
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseColumnTextForButtonValue = true;
            // 
            // BajaRecorrido
            // 
            this.BajaRecorrido.HeaderText = "";
            this.BajaRecorrido.Name = "BajaRecorrido";
            this.BajaRecorrido.ReadOnly = true;
            this.BajaRecorrido.Text = "Dar de baja";
            this.BajaRecorrido.UseColumnTextForButtonValue = true;
            // 
            // ListadoRecorridoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 537);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.dataGridViewRecorrido);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.groupBoxFiltrosRecorrido);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListadoRecorridoForm";
            this.Text = "Listado Recorridos";
            this.groupBoxFiltrosRecorrido.ResumeLayout(false);
            this.groupBoxFiltrosRecorrido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecorrido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHabilitado;
        private System.Windows.Forms.ComboBox comboBoxHabilitado;
        private System.Windows.Forms.Label labelPuertoDesde;
        private System.Windows.Forms.Label labelPuertoHasta;
        private System.Windows.Forms.TextBox textBoxPuertoDesde;
        private System.Windows.Forms.Button buttonSeleccionarDesde;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPuertoHasta;
        private System.Windows.Forms.GroupBox groupBoxFiltrosRecorrido;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridView dataGridViewRecorrido;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn BajaRecorrido;
    }
}