namespace FrbaCrucero.ListadoEstadistico
{
    partial class ListadoEstadisticoForm
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
            this.buttonRecorridosMasPasajes = new System.Windows.Forms.Button();
            this.buttonRecorridosMasCabinasLibres = new System.Windows.Forms.Button();
            this.buttonCrucerosDiasSinServicio = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboSemestre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resultadosTop5Grid = new System.Windows.Forms.DataGridView();
            this.limpiarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultadosTop5Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRecorridosMasPasajes
            // 
            this.buttonRecorridosMasPasajes.Location = new System.Drawing.Point(11, 102);
            this.buttonRecorridosMasPasajes.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRecorridosMasPasajes.Name = "buttonRecorridosMasPasajes";
            this.buttonRecorridosMasPasajes.Size = new System.Drawing.Size(172, 39);
            this.buttonRecorridosMasPasajes.TabIndex = 0;
            this.buttonRecorridosMasPasajes.Text = "Recorridos con más pasajes vendidos";
            this.buttonRecorridosMasPasajes.UseVisualStyleBackColor = true;
            this.buttonRecorridosMasPasajes.Click += new System.EventHandler(this.buttonRecorridosMasPasajes_Click);
            // 
            // buttonRecorridosMasCabinasLibres
            // 
            this.buttonRecorridosMasCabinasLibres.Location = new System.Drawing.Point(209, 102);
            this.buttonRecorridosMasCabinasLibres.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRecorridosMasCabinasLibres.Name = "buttonRecorridosMasCabinasLibres";
            this.buttonRecorridosMasCabinasLibres.Size = new System.Drawing.Size(175, 39);
            this.buttonRecorridosMasCabinasLibres.TabIndex = 1;
            this.buttonRecorridosMasCabinasLibres.Text = "Recorridos con más cabinas libres";
            this.buttonRecorridosMasCabinasLibres.UseVisualStyleBackColor = true;
            this.buttonRecorridosMasCabinasLibres.Click += new System.EventHandler(this.buttonRecorridosMasCabinasLibres_Click);
            // 
            // buttonCrucerosDiasSinServicio
            // 
            this.buttonCrucerosDiasSinServicio.Location = new System.Drawing.Point(415, 102);
            this.buttonCrucerosDiasSinServicio.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCrucerosDiasSinServicio.Name = "buttonCrucerosDiasSinServicio";
            this.buttonCrucerosDiasSinServicio.Size = new System.Drawing.Size(174, 39);
            this.buttonCrucerosDiasSinServicio.TabIndex = 2;
            this.buttonCrucerosDiasSinServicio.Text = "Cruceros con más días sin servicio";
            this.buttonCrucerosDiasSinServicio.UseVisualStyleBackColor = true;
            this.buttonCrucerosDiasSinServicio.Click += new System.EventHandler(this.buttonCrucerosDiasSinServicio_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 28);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // comboSemestre
            // 
            this.comboSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSemestre.FormattingEnabled = true;
            this.comboSemestre.Location = new System.Drawing.Point(334, 28);
            this.comboSemestre.Name = "comboSemestre";
            this.comboSemestre.Size = new System.Drawing.Size(139, 21);
            this.comboSemestre.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Semestre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Año";
            // 
            // resultadosTop5Grid
            // 
            this.resultadosTop5Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultadosTop5Grid.Location = new System.Drawing.Point(129, 158);
            this.resultadosTop5Grid.Name = "resultadosTop5Grid";
            this.resultadosTop5Grid.Size = new System.Drawing.Size(344, 227);
            this.resultadosTop5Grid.TabIndex = 26;
            // 
            // limpiarButton
            // 
            this.limpiarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.limpiarButton.Location = new System.Drawing.Point(502, 23);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(75, 30);
            this.limpiarButton.TabIndex = 27;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
            // 
            // ListadoEstadisticoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 397);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.resultadosTop5Grid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboSemestre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonCrucerosDiasSinServicio);
            this.Controls.Add(this.buttonRecorridosMasCabinasLibres);
            this.Controls.Add(this.buttonRecorridosMasPasajes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListadoEstadisticoForm";
            this.Text = "ListadoEstadistico";
            ((System.ComponentModel.ISupportInitialize)(this.resultadosTop5Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRecorridosMasPasajes;
        private System.Windows.Forms.Button buttonRecorridosMasCabinasLibres;
        private System.Windows.Forms.Button buttonCrucerosDiasSinServicio;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboSemestre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView resultadosTop5Grid;
        private System.Windows.Forms.Button limpiarButton;
    }
}