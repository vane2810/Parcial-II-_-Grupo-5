
namespace Parcial_II___Grupo_5.PL
{
    partial class frmCartelera
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
            this.txtId_funcion = new System.Windows.Forms.TextBox();
            this.txtNombre_pelicula = new System.Windows.Forms.TextBox();
            this.txtPeriodo_pelicula = new System.Windows.Forms.TextBox();
            this.txtGanancias_funcion = new System.Windows.Forms.TextBox();
            this.txtGanancias_diarias = new System.Windows.Forms.TextBox();
            this.txtGanancias_totales = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvCartelera = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartelera)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(24, 23);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(54, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Id función";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(12, 68);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(111, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Nombre de la película";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(12, 120);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(112, 13);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Período de la película";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(12, 164);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(114, 13);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "Ganancias por función";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(24, 212);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(94, 13);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "Ganancias diarias ";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(24, 256);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(92, 13);
            this.lbl6.TabIndex = 5;
            this.lbl6.Text = "Ganancias totales";
            // 
            // txtId_funcion
            // 
            this.txtId_funcion.Location = new System.Drawing.Point(139, 16);
            this.txtId_funcion.Name = "txtId_funcion";
            this.txtId_funcion.Size = new System.Drawing.Size(430, 20);
            this.txtId_funcion.TabIndex = 7;
            // 
            // txtNombre_pelicula
            // 
            this.txtNombre_pelicula.Location = new System.Drawing.Point(139, 65);
            this.txtNombre_pelicula.Name = "txtNombre_pelicula";
            this.txtNombre_pelicula.Size = new System.Drawing.Size(430, 20);
            this.txtNombre_pelicula.TabIndex = 8;
            // 
            // txtPeriodo_pelicula
            // 
            this.txtPeriodo_pelicula.Location = new System.Drawing.Point(139, 113);
            this.txtPeriodo_pelicula.Name = "txtPeriodo_pelicula";
            this.txtPeriodo_pelicula.Size = new System.Drawing.Size(430, 20);
            this.txtPeriodo_pelicula.TabIndex = 9;
            // 
            // txtGanancias_funcion
            // 
            this.txtGanancias_funcion.Location = new System.Drawing.Point(139, 157);
            this.txtGanancias_funcion.Name = "txtGanancias_funcion";
            this.txtGanancias_funcion.Size = new System.Drawing.Size(430, 20);
            this.txtGanancias_funcion.TabIndex = 10;
            // 
            // txtGanancias_diarias
            // 
            this.txtGanancias_diarias.Location = new System.Drawing.Point(139, 205);
            this.txtGanancias_diarias.Name = "txtGanancias_diarias";
            this.txtGanancias_diarias.Size = new System.Drawing.Size(430, 20);
            this.txtGanancias_diarias.TabIndex = 11;
            // 
            // txtGanancias_totales
            // 
            this.txtGanancias_totales.Location = new System.Drawing.Point(139, 249);
            this.txtGanancias_totales.Name = "txtGanancias_totales";
            this.txtGanancias_totales.Size = new System.Drawing.Size(430, 20);
            this.txtGanancias_totales.TabIndex = 12;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(478, 296);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 14;
            this.btnInsert.Text = "Insertar";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(478, 369);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(478, 443);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(478, 515);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // dgvCartelera
            // 
            this.dgvCartelera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCartelera.Location = new System.Drawing.Point(27, 296);
            this.dgvCartelera.Name = "dgvCartelera";
            this.dgvCartelera.Size = new System.Drawing.Size(412, 242);
            this.dgvCartelera.TabIndex = 18;
            this.dgvCartelera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCartelera_CellContentClick);
            // 
            // frmCartelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 550);
            this.Controls.Add(this.dgvCartelera);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtGanancias_totales);
            this.Controls.Add(this.txtGanancias_diarias);
            this.Controls.Add(this.txtGanancias_funcion);
            this.Controls.Add(this.txtPeriodo_pelicula);
            this.Controls.Add(this.txtNombre_pelicula);
            this.Controls.Add(this.txtId_funcion);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "frmCartelera";
            this.Text = "frmFunciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartelera)).EndInit();
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
        private System.Windows.Forms.TextBox txtId_funcion;
        private System.Windows.Forms.TextBox txtNombre_pelicula;
        private System.Windows.Forms.TextBox txtPeriodo_pelicula;
        private System.Windows.Forms.TextBox txtGanancias_funcion;
        private System.Windows.Forms.TextBox txtGanancias_diarias;
        private System.Windows.Forms.TextBox txtGanancias_totales;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvCartelera;
    }
}