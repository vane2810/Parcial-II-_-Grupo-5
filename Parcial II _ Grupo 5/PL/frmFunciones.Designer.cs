
namespace Parcial_II___Grupo_5.PL
{
    partial class frmFunciones
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvFunciones = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtEntrada_adultos = new System.Windows.Forms.TextBox();
            this.txtEntrada_niños = new System.Windows.Forms.TextBox();
            this.txtEntrada_estudiantes = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtFunciones_diarias = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(73, 33);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(19, 17);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Id";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(28, 105);
            this.lbl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(125, 17);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Entradas - Adultos";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(259, 105);
            this.lbl4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(118, 17);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "Entradas -  Niños";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(497, 105);
            this.lbl5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(152, 17);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "Entradas - Estudiantes";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(15, 238);
            this.lbl6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(152, 17);
            this.lbl6.TabIndex = 5;
            this.lbl6.Text = "Duración de la película";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 313);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Funciones diarias";
            // 
            // dgvFunciones
            // 
            this.dgvFunciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunciones.Location = new System.Drawing.Point(19, 398);
            this.dgvFunciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvFunciones.Name = "dgvFunciones";
            this.dgvFunciones.RowHeadersWidth = 51;
            this.dgvFunciones.Size = new System.Drawing.Size(616, 255);
            this.dgvFunciones.TabIndex = 7;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(321, 276);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 28);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insertar";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(501, 276);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(321, 343);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(501, 343);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(180, 25);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(453, 22);
            this.txtId.TabIndex = 12;
            // 
            // txtEntrada_adultos
            // 
            this.txtEntrada_adultos.Location = new System.Drawing.Point(19, 150);
            this.txtEntrada_adultos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEntrada_adultos.Name = "txtEntrada_adultos";
            this.txtEntrada_adultos.Size = new System.Drawing.Size(132, 22);
            this.txtEntrada_adultos.TabIndex = 14;
            // 
            // txtEntrada_niños
            // 
            this.txtEntrada_niños.Location = new System.Drawing.Point(263, 150);
            this.txtEntrada_niños.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEntrada_niños.Name = "txtEntrada_niños";
            this.txtEntrada_niños.Size = new System.Drawing.Size(132, 22);
            this.txtEntrada_niños.TabIndex = 15;
            // 
            // txtEntrada_estudiantes
            // 
            this.txtEntrada_estudiantes.Location = new System.Drawing.Point(501, 150);
            this.txtEntrada_estudiantes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEntrada_estudiantes.Name = "txtEntrada_estudiantes";
            this.txtEntrada_estudiantes.Size = new System.Drawing.Size(132, 22);
            this.txtEntrada_estudiantes.TabIndex = 16;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(180, 229);
            this.txtDuracion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(467, 22);
            this.txtDuracion.TabIndex = 17;
            // 
            // txtFunciones_diarias
            // 
            this.txtFunciones_diarias.Location = new System.Drawing.Point(156, 309);
            this.txtFunciones_diarias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFunciones_diarias.Name = "txtFunciones_diarias";
            this.txtFunciones_diarias.Size = new System.Drawing.Size(132, 22);
            this.txtFunciones_diarias.TabIndex = 18;
            // 
            // frmFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(656, 667);
            this.Controls.Add(this.txtFunciones_diarias);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.txtEntrada_estudiantes);
            this.Controls.Add(this.txtEntrada_niños);
            this.Controls.Add(this.txtEntrada_adultos);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dgvFunciones);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmFunciones";
            this.Text = "frmFunciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvFunciones;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtEntrada_adultos;
        private System.Windows.Forms.TextBox txtEntrada_niños;
        private System.Windows.Forms.TextBox txtEntrada_estudiantes;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtFunciones_diarias;
    }
}