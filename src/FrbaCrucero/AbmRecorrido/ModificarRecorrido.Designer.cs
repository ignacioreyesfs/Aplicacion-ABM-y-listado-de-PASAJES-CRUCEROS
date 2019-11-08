namespace FrbaCrucero.AbmRecorrido
{
    partial class ModificarRecorrido
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
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelTodosLosTramos = new System.Windows.Forms.Label();
            this.labelTramos = new System.Windows.Forms.Label();
            this.dataGridViewTramosActuales = new System.Windows.Forms.DataGridView();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.dataGridViewTramosTotales = new System.Windows.Forms.DataGridView();
            this.Agregar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.QuitarButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTramosActuales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTramosTotales)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(154, 20);
            this.textBoxCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(195, 22);
            this.textBoxCodigo.TabIndex = 16;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(12, 20);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(136, 17);
            this.labelCodigo.TabIndex = 15;
            this.labelCodigo.Text = "Codigo del recorrido";
            // 
            // labelTodosLosTramos
            // 
            this.labelTodosLosTramos.AutoSize = true;
            this.labelTodosLosTramos.Location = new System.Drawing.Point(579, 54);
            this.labelTodosLosTramos.Name = "labelTodosLosTramos";
            this.labelTodosLosTramos.Size = new System.Drawing.Size(121, 17);
            this.labelTodosLosTramos.TabIndex = 14;
            this.labelTodosLosTramos.Text = "Todos los tramos:";
            // 
            // labelTramos
            // 
            this.labelTramos.AutoSize = true;
            this.labelTramos.Location = new System.Drawing.Point(12, 54);
            this.labelTramos.Name = "labelTramos";
            this.labelTramos.Size = new System.Drawing.Size(144, 17);
            this.labelTramos.TabIndex = 13;
            this.labelTramos.Text = "Tramos del recorrido:";
            // 
            // dataGridViewTramosActuales
            // 
            this.dataGridViewTramosActuales.AllowUserToAddRows = false;
            this.dataGridViewTramosActuales.AllowUserToDeleteRows = false;
            this.dataGridViewTramosActuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTramosActuales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuitarButton});
            this.dataGridViewTramosActuales.Location = new System.Drawing.Point(15, 84);
            this.dataGridViewTramosActuales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTramosActuales.Name = "dataGridViewTramosActuales";
            this.dataGridViewTramosActuales.ReadOnly = true;
            this.dataGridViewTramosActuales.RowTemplate.Height = 24;
            this.dataGridViewTramosActuales.Size = new System.Drawing.Size(501, 411);
            this.dataGridViewTramosActuales.TabIndex = 12;
            this.dataGridViewTramosActuales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTramosActuales_CellContentClick);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(936, 501);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(115, 36);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(1056, 501);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(115, 36);
            this.buttonGuardar.TabIndex = 10;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // dataGridViewTramosTotales
            // 
            this.dataGridViewTramosTotales.AllowUserToAddRows = false;
            this.dataGridViewTramosTotales.AllowUserToDeleteRows = false;
            this.dataGridViewTramosTotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTramosTotales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Agregar});
            this.dataGridViewTramosTotales.Location = new System.Drawing.Point(582, 84);
            this.dataGridViewTramosTotales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTramosTotales.Name = "dataGridViewTramosTotales";
            this.dataGridViewTramosTotales.ReadOnly = true;
            this.dataGridViewTramosTotales.RowTemplate.Height = 24;
            this.dataGridViewTramosTotales.Size = new System.Drawing.Size(589, 411);
            this.dataGridViewTramosTotales.TabIndex = 9;
            this.dataGridViewTramosTotales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTramosTotales_CellContentClick);
            // 
            // Agregar
            // 
            this.Agregar.HeaderText = "";
            this.Agregar.Name = "Agregar";
            this.Agregar.ReadOnly = true;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseColumnTextForButtonValue = true;
            // 
            // QuitarButton
            // 
            this.QuitarButton.HeaderText = "";
            this.QuitarButton.Name = "QuitarButton";
            this.QuitarButton.ReadOnly = true;
            this.QuitarButton.Text = "Quitar";
            this.QuitarButton.UseColumnTextForButtonValue = true;
            // 
            // ModificarRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 547);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.labelTodosLosTramos);
            this.Controls.Add(this.labelTramos);
            this.Controls.Add(this.dataGridViewTramosActuales);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.dataGridViewTramosTotales);
            this.Name = "ModificarRecorrido";
            this.Text = "ModificarRecorrido";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTramosActuales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTramosTotales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelTodosLosTramos;
        private System.Windows.Forms.Label labelTramos;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.DataGridView dataGridViewTramosTotales;
        private System.Windows.Forms.DataGridViewButtonColumn Agregar;
        private System.Windows.Forms.DataGridViewButtonColumn QuitarButton;
        private System.Windows.Forms.DataGridView dataGridViewTramosActuales;
    }
}