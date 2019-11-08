namespace FrbaCrucero.CompraPasaje
{
    partial class CompraReservaPasajeForm
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
            this.textBoxFechaInicio = new System.Windows.Forms.TextBox();
            this.textBoxFechaFin = new System.Windows.Forms.TextBox();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.labelFechaFin = new System.Windows.Forms.Label();
            this.textBoxPuertoOrigen = new System.Windows.Forms.TextBox();
            this.labelIDPuertoOrigen = new System.Windows.Forms.Label();
            this.textBoxPuertoDestino = new System.Windows.Forms.TextBox();
            this.labelPuertoDestino = new System.Windows.Forms.Label();
            this.groupBoxFiltroCompraReservaPasaje = new System.Windows.Forms.GroupBox();
            this.dataGridViewViajes = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonSeleccionarFechaInicio = new System.Windows.Forms.Button();
            this.buttonSeleccionarFechaFin = new System.Windows.Forms.Button();
            this.buttonSeleccionarPuertoOrigen = new System.Windows.Forms.Button();
            this.buttonSeleccionarPuertoDestino = new System.Windows.Forms.Button();
            this.groupBoxFiltroCompraReservaPasaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFechaInicio
            // 
            this.textBoxFechaInicio.Location = new System.Drawing.Point(95, 22);
            this.textBoxFechaInicio.Name = "textBoxFechaInicio";
            this.textBoxFechaInicio.Size = new System.Drawing.Size(100, 22);
            this.textBoxFechaInicio.TabIndex = 0;
            // 
            // textBoxFechaFin
            // 
            this.textBoxFechaFin.Location = new System.Drawing.Point(95, 50);
            this.textBoxFechaFin.Name = "textBoxFechaFin";
            this.textBoxFechaFin.Size = new System.Drawing.Size(100, 22);
            this.textBoxFechaFin.TabIndex = 1;
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Location = new System.Drawing.Point(6, 22);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(83, 17);
            this.labelFechaInicio.TabIndex = 2;
            this.labelFechaInicio.Text = "Fecha inicio";
            // 
            // labelFechaFin
            // 
            this.labelFechaFin.AutoSize = true;
            this.labelFechaFin.Location = new System.Drawing.Point(6, 50);
            this.labelFechaFin.Name = "labelFechaFin";
            this.labelFechaFin.Size = new System.Drawing.Size(66, 17);
            this.labelFechaFin.TabIndex = 3;
            this.labelFechaFin.Text = "Fecha fin";
            // 
            // textBoxPuertoOrigen
            // 
            this.textBoxPuertoOrigen.Location = new System.Drawing.Point(560, 21);
            this.textBoxPuertoOrigen.Name = "textBoxPuertoOrigen";
            this.textBoxPuertoOrigen.Size = new System.Drawing.Size(100, 22);
            this.textBoxPuertoOrigen.TabIndex = 4;
            // 
            // labelIDPuertoOrigen
            // 
            this.labelIDPuertoOrigen.AutoSize = true;
            this.labelIDPuertoOrigen.Location = new System.Drawing.Point(460, 22);
            this.labelIDPuertoOrigen.Name = "labelIDPuertoOrigen";
            this.labelIDPuertoOrigen.Size = new System.Drawing.Size(94, 17);
            this.labelIDPuertoOrigen.TabIndex = 5;
            this.labelIDPuertoOrigen.Text = "Puerto origen";
            // 
            // textBoxPuertoDestino
            // 
            this.textBoxPuertoDestino.Location = new System.Drawing.Point(560, 51);
            this.textBoxPuertoDestino.Name = "textBoxPuertoDestino";
            this.textBoxPuertoDestino.Size = new System.Drawing.Size(100, 22);
            this.textBoxPuertoDestino.TabIndex = 6;
            // 
            // labelPuertoDestino
            // 
            this.labelPuertoDestino.AutoSize = true;
            this.labelPuertoDestino.Location = new System.Drawing.Point(460, 51);
            this.labelPuertoDestino.Name = "labelPuertoDestino";
            this.labelPuertoDestino.Size = new System.Drawing.Size(100, 17);
            this.labelPuertoDestino.TabIndex = 7;
            this.labelPuertoDestino.Text = "Puerto destino";
            // 
            // groupBoxFiltroCompraReservaPasaje
            // 
            this.groupBoxFiltroCompraReservaPasaje.Controls.Add(this.buttonSeleccionarPuertoDestino);
            this.groupBoxFiltroCompraReservaPasaje.Controls.Add(this.buttonSeleccionarPuertoOrigen);
            this.groupBoxFiltroCompraReservaPasaje.Controls.Add(this.buttonSeleccionarFechaFin);
            this.groupBoxFiltroCompraReservaPasaje.Controls.Add(this.buttonSeleccionarFechaInicio);
            this.groupBoxFiltroCompraReservaPasaje.Controls.Add(this.labelIDPuertoOrigen);
            this.groupBoxFiltroCompraReservaPasaje.Controls.Add(this.labelPuertoDestino);
            this.groupBoxFiltroCompraReservaPasaje.Controls.Add(this.textBoxFechaInicio);
            this.groupBoxFiltroCompraReservaPasaje.Controls.Add(this.textBoxPuertoDestino);
            this.groupBoxFiltroCompraReservaPasaje.Controls.Add(this.textBoxFechaFin);
            this.groupBoxFiltroCompraReservaPasaje.Controls.Add(this.labelFechaInicio);
            this.groupBoxFiltroCompraReservaPasaje.Controls.Add(this.textBoxPuertoOrigen);
            this.groupBoxFiltroCompraReservaPasaje.Controls.Add(this.labelFechaFin);
            this.groupBoxFiltroCompraReservaPasaje.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFiltroCompraReservaPasaje.Name = "groupBoxFiltroCompraReservaPasaje";
            this.groupBoxFiltroCompraReservaPasaje.Size = new System.Drawing.Size(785, 91);
            this.groupBoxFiltroCompraReservaPasaje.TabIndex = 8;
            this.groupBoxFiltroCompraReservaPasaje.TabStop = false;
            this.groupBoxFiltroCompraReservaPasaje.Text = "Filtro viajes";
            // 
            // dataGridViewViajes
            // 
            this.dataGridViewViajes.AllowUserToAddRows = false;
            this.dataGridViewViajes.AllowUserToDeleteRows = false;
            this.dataGridViewViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewViajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dataGridViewViajes.Location = new System.Drawing.Point(12, 150);
            this.dataGridViewViajes.Name = "dataGridViewViajes";
            this.dataGridViewViajes.ReadOnly = true;
            this.dataGridViewViajes.RowTemplate.Height = 24;
            this.dataGridViewViajes.Size = new System.Drawing.Size(785, 379);
            this.dataGridViewViajes.TabIndex = 9;
            this.dataGridViewViajes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewViajes_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Text = "Seleccionar";
            this.Seleccionar.UseColumnTextForButtonValue = true;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(682, 110);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(115, 34);
            this.buttonBuscar.TabIndex = 10;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(12, 110);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(115, 34);
            this.buttonLimpiar.TabIndex = 11;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonSeleccionarFechaInicio
            // 
            this.buttonSeleccionarFechaInicio.Location = new System.Drawing.Point(202, 22);
            this.buttonSeleccionarFechaInicio.Name = "buttonSeleccionarFechaInicio";
            this.buttonSeleccionarFechaInicio.Size = new System.Drawing.Size(98, 23);
            this.buttonSeleccionarFechaInicio.TabIndex = 8;
            this.buttonSeleccionarFechaInicio.Text = "Seleccionar";
            this.buttonSeleccionarFechaInicio.UseVisualStyleBackColor = true;
            this.buttonSeleccionarFechaInicio.Click += new System.EventHandler(this.buttonSeleccionarFechaInicio_Click);
            // 
            // buttonSeleccionarFechaFin
            // 
            this.buttonSeleccionarFechaFin.Location = new System.Drawing.Point(202, 51);
            this.buttonSeleccionarFechaFin.Name = "buttonSeleccionarFechaFin";
            this.buttonSeleccionarFechaFin.Size = new System.Drawing.Size(98, 23);
            this.buttonSeleccionarFechaFin.TabIndex = 9;
            this.buttonSeleccionarFechaFin.Text = "Seleccionar";
            this.buttonSeleccionarFechaFin.UseVisualStyleBackColor = true;
            this.buttonSeleccionarFechaFin.Click += new System.EventHandler(this.buttonSeleccionarFechaFin_Click);
            // 
            // buttonSeleccionarPuertoOrigen
            // 
            this.buttonSeleccionarPuertoOrigen.Location = new System.Drawing.Point(666, 19);
            this.buttonSeleccionarPuertoOrigen.Name = "buttonSeleccionarPuertoOrigen";
            this.buttonSeleccionarPuertoOrigen.Size = new System.Drawing.Size(98, 23);
            this.buttonSeleccionarPuertoOrigen.TabIndex = 10;
            this.buttonSeleccionarPuertoOrigen.Text = "Seleccionar";
            this.buttonSeleccionarPuertoOrigen.UseVisualStyleBackColor = true;
            this.buttonSeleccionarPuertoOrigen.Click += new System.EventHandler(this.buttonSeleccionarPuertoOrigen_Click);
            // 
            // buttonSeleccionarPuertoDestino
            // 
            this.buttonSeleccionarPuertoDestino.Location = new System.Drawing.Point(667, 50);
            this.buttonSeleccionarPuertoDestino.Name = "buttonSeleccionarPuertoDestino";
            this.buttonSeleccionarPuertoDestino.Size = new System.Drawing.Size(97, 23);
            this.buttonSeleccionarPuertoDestino.TabIndex = 11;
            this.buttonSeleccionarPuertoDestino.Text = "Seleccionar";
            this.buttonSeleccionarPuertoDestino.UseVisualStyleBackColor = true;
            this.buttonSeleccionarPuertoDestino.Click += new System.EventHandler(this.buttonSeleccionarPuertoDestino_Click);
            // 
            // CompraReservaPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 541);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.dataGridViewViajes);
            this.Controls.Add(this.groupBoxFiltroCompraReservaPasaje);
            this.Name = "CompraReservaPasaje";
            this.Text = "Compra y reserva de pasaje";
            this.groupBoxFiltroCompraReservaPasaje.ResumeLayout(false);
            this.groupBoxFiltroCompraReservaPasaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFechaInicio;
        private System.Windows.Forms.TextBox textBoxFechaFin;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Label labelFechaFin;
        private System.Windows.Forms.TextBox textBoxPuertoOrigen;
        private System.Windows.Forms.Label labelIDPuertoOrigen;
        private System.Windows.Forms.TextBox textBoxPuertoDestino;
        private System.Windows.Forms.Label labelPuertoDestino;
        private System.Windows.Forms.GroupBox groupBoxFiltroCompraReservaPasaje;
        private System.Windows.Forms.DataGridView dataGridViewViajes;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonSeleccionarPuertoDestino;
        private System.Windows.Forms.Button buttonSeleccionarPuertoOrigen;
        private System.Windows.Forms.Button buttonSeleccionarFechaFin;
        private System.Windows.Forms.Button buttonSeleccionarFechaInicio;
    }
}