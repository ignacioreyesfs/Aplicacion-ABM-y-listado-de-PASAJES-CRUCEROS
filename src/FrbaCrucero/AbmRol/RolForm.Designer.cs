namespace FrbaCrucero.AbmRol
{
    partial class RolForm
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
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.labelHabilitado = new System.Windows.Forms.Label();
            this.checkBoxHabilitado = new System.Windows.Forms.CheckBox();
            this.dataGridViewFuncionalidades = new System.Windows.Forms.DataGridView();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonEliminarFunc = new System.Windows.Forms.Button();
            this.buttonAgregarFunc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(12, 9);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(44, 13);
            this.labelDescripcion.TabIndex = 0;
            this.labelDescripcion.Text = "Nombre";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(72, 6);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(143, 20);
            this.textBoxDescripcion.TabIndex = 1;
            // 
            // labelHabilitado
            // 
            this.labelHabilitado.AutoSize = true;
            this.labelHabilitado.Location = new System.Drawing.Point(12, 50);
            this.labelHabilitado.Name = "labelHabilitado";
            this.labelHabilitado.Size = new System.Drawing.Size(54, 13);
            this.labelHabilitado.TabIndex = 2;
            this.labelHabilitado.Text = "Habilitado";
            // 
            // checkBoxHabilitado
            // 
            this.checkBoxHabilitado.AutoSize = true;
            this.checkBoxHabilitado.Location = new System.Drawing.Point(72, 49);
            this.checkBoxHabilitado.Name = "checkBoxHabilitado";
            this.checkBoxHabilitado.Size = new System.Drawing.Size(15, 14);
            this.checkBoxHabilitado.TabIndex = 3;
            this.checkBoxHabilitado.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFuncionalidades
            // 
            this.dataGridViewFuncionalidades.AllowUserToAddRows = false;
            this.dataGridViewFuncionalidades.AllowUserToDeleteRows = false;
            this.dataGridViewFuncionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFuncionalidades.Location = new System.Drawing.Point(12, 98);
            this.dataGridViewFuncionalidades.Name = "dataGridViewFuncionalidades";
            this.dataGridViewFuncionalidades.ReadOnly = true;
            this.dataGridViewFuncionalidades.Size = new System.Drawing.Size(285, 180);
            this.dataGridViewFuncionalidades.TabIndex = 4;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(12, 368);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(222, 368);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 7;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonEliminarFunc
            // 
            this.buttonEliminarFunc.Location = new System.Drawing.Point(12, 284);
            this.buttonEliminarFunc.Name = "buttonEliminarFunc";
            this.buttonEliminarFunc.Size = new System.Drawing.Size(27, 24);
            this.buttonEliminarFunc.TabIndex = 8;
            this.buttonEliminarFunc.Text = "-";
            this.buttonEliminarFunc.UseVisualStyleBackColor = true;
            this.buttonEliminarFunc.Click += new System.EventHandler(this.buttonEliminarFunc_Click);
            // 
            // buttonAgregarFunc
            // 
            this.buttonAgregarFunc.Location = new System.Drawing.Point(45, 284);
            this.buttonAgregarFunc.Name = "buttonAgregarFunc";
            this.buttonAgregarFunc.Size = new System.Drawing.Size(27, 24);
            this.buttonAgregarFunc.TabIndex = 9;
            this.buttonAgregarFunc.Text = "+";
            this.buttonAgregarFunc.UseVisualStyleBackColor = true;
            this.buttonAgregarFunc.Click += new System.EventHandler(this.buttonAgregarFunc_Click);
            // 
            // RolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 403);
            this.Controls.Add(this.buttonAgregarFunc);
            this.Controls.Add(this.buttonEliminarFunc);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.dataGridViewFuncionalidades);
            this.Controls.Add(this.checkBoxHabilitado);
            this.Controls.Add(this.labelHabilitado);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.labelDescripcion);
            this.Name = "RolForm";
            this.Text = "Rol";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RolForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label labelHabilitado;
        private System.Windows.Forms.CheckBox checkBoxHabilitado;
        private System.Windows.Forms.DataGridView dataGridViewFuncionalidades;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonEliminarFunc;
        private System.Windows.Forms.Button buttonAgregarFunc;
    }
}