
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
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DgwFunciones = new System.Windows.Forms.DataGridView();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtId_salas = new System.Windows.Forms.TextBox();
            this.txtEntrada_adultos = new System.Windows.Forms.TextBox();
            this.txtEntrada_Niños = new System.Windows.Forms.TextBox();
            this.txtEntradas_estudiantes = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtFunciones_diarias = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgwFunciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(55, 27);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(16, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Id";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(36, 76);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(43, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Id salas";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(21, 121);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(93, 13);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Entradas - Adultos";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(203, 121);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(88, 13);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "Entradas -  Niños";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(373, 121);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(113, 13);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "Entradas - Estudiantes";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(11, 217);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(117, 13);
            this.lbl6.TabIndex = 5;
            this.lbl6.Text = "Duración de la película";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Funciones diarias";
            // 
            // DgwFunciones
            // 
            this.DgwFunciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwFunciones.Location = new System.Drawing.Point(14, 327);
            this.DgwFunciones.Name = "DgwFunciones";
            this.DgwFunciones.Size = new System.Drawing.Size(462, 207);
            this.DgwFunciones.TabIndex = 7;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(241, 249);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 8;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(376, 249);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(241, 298);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(376, 297);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(135, 20);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(341, 20);
            this.txtId.TabIndex = 12;
            // 
            // txtId_salas
            // 
            this.txtId_salas.Location = new System.Drawing.Point(135, 69);
            this.txtId_salas.Name = "txtId_salas";
            this.txtId_salas.Size = new System.Drawing.Size(341, 20);
            this.txtId_salas.TabIndex = 13;
            // 
            // txtEntrada_adultos
            // 
            this.txtEntrada_adultos.Location = new System.Drawing.Point(14, 159);
            this.txtEntrada_adultos.Name = "txtEntrada_adultos";
            this.txtEntrada_adultos.Size = new System.Drawing.Size(100, 20);
            this.txtEntrada_adultos.TabIndex = 14;
            // 
            // txtEntrada_Niños
            // 
            this.txtEntrada_Niños.Location = new System.Drawing.Point(197, 159);
            this.txtEntrada_Niños.Name = "txtEntrada_Niños";
            this.txtEntrada_Niños.Size = new System.Drawing.Size(100, 20);
            this.txtEntrada_Niños.TabIndex = 15;
            // 
            // txtEntradas_estudiantes
            // 
            this.txtEntradas_estudiantes.Location = new System.Drawing.Point(376, 159);
            this.txtEntradas_estudiantes.Name = "txtEntradas_estudiantes";
            this.txtEntradas_estudiantes.Size = new System.Drawing.Size(100, 20);
            this.txtEntradas_estudiantes.TabIndex = 16;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(135, 214);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(351, 20);
            this.txtDuracion.TabIndex = 17;
            // 
            // txtFunciones_diarias
            // 
            this.txtFunciones_diarias.Location = new System.Drawing.Point(114, 271);
            this.txtFunciones_diarias.Name = "txtFunciones_diarias";
            this.txtFunciones_diarias.Size = new System.Drawing.Size(100, 20);
            this.txtFunciones_diarias.TabIndex = 18;
            // 
            // frmFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 542);
            this.Controls.Add(this.txtFunciones_diarias);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.txtEntradas_estudiantes);
            this.Controls.Add(this.txtEntrada_Niños);
            this.Controls.Add(this.txtEntrada_adultos);
            this.Controls.Add(this.txtId_salas);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.DgwFunciones);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "frmFunciones";
            this.Text = "frmFunciones";
            ((System.ComponentModel.ISupportInitialize)(this.DgwFunciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DgwFunciones;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtId_salas;
        private System.Windows.Forms.TextBox txtEntrada_adultos;
        private System.Windows.Forms.TextBox txtEntrada_Niños;
        private System.Windows.Forms.TextBox txtEntradas_estudiantes;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtFunciones_diarias;
    }
}