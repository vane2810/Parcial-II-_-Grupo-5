using Parcial_II___Grupo_5.BLL;
using Parcial_II___Grupo_5.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_II___Grupo_5.PL
{
    public partial class frmFunciones : Form
    {
        FuncionesDAL funciones;
        public frmFunciones()
        {
            InitializeComponent();
            funciones = new FuncionesDAL();
        }

        private void dgvFunciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fillDgvFunciones();
        }

        private void fillDgvFunciones()
        {
            dgvFunciones.DataSource = funciones.getAllFunciones();
        }

        private void clearTextBox()
        {
            txtId.Clear();
            txtEntrada_adultos.Clear();
            txtEntrada_niños.Clear();
            txtEntrada_estudiantes.Clear();
            txtDuracion.Clear();
            txtFunciones_diarias.Clear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEntrada_adultos.Text) || string.IsNullOrEmpty(txtEntrada_niños.Text)
                || string.IsNullOrEmpty(txtEntrada_estudiantes.Text) || string.IsNullOrEmpty(txtDuracion.Text)
                || string.IsNullOrEmpty(txtFunciones_diarias.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                int entrada_adultos = int.Parse(txtEntrada_adultos.Text);
                int entrada_niños = int.Parse(txtEntrada_niños.Text);
                int entrada_estudiantes = int.Parse(txtEntrada_estudiantes.Text);
                string duracion_pelicula = txtDuracion.Text;
                int funciones_diarias= int.Parse(txtFunciones_diarias.Text);
                FuncionesBLL funcion = new FuncionesBLL(0, entrada_adultos, entrada_niños, entrada_estudiantes, duracion_pelicula, funciones_diarias);
                if (funciones.createFuncion(funcion))
                {
                    MessageBox.Show("Los datos se ingresaron con éxito");
                    fillDgvFunciones();
                    clearTextBox();
                }
                else
                {
                    MessageBox.Show("No se pudieron ingresar los datos");
                }
            }
        }
        private void DgvFunciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtId.Text = dgvFunciones.Rows[index].Cells[0].Value.ToString();
                txtEntrada_adultos.Text = dgvFunciones.Rows[index].Cells[1].Value.ToString();
                txtEntrada_niños.Text = dgvFunciones.Rows[index].Cells[2].Value.ToString();
                txtEntrada_estudiantes.Text = dgvFunciones.Rows[index].Cells[3].Value.ToString();
                txtDuracion.Text = dgvFunciones.Rows[index].Cells[4].Value.ToString();
                txtFunciones_diarias.Text = dgvFunciones.Rows[index].Cells[5].Value.ToString();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtEntrada_adultos.Text)
                || string.IsNullOrEmpty(txtEntrada_niños.Text) || string.IsNullOrEmpty(txtEntrada_estudiantes.Text)
                || string.IsNullOrEmpty(txtDuracion.Text) || string.IsNullOrEmpty(txtFunciones_diarias.Text))
            {
                MessageBox.Show("Debe completar todos los campos requeridos");
            }
            else
            {
                int id = int.Parse(txtId.Text);
                int entrada_adultos = int.Parse(txtEntrada_adultos.Text);
                int entrada_niños = int.Parse(txtEntrada_niños.Text);
                int entrada_estudiantes = int.Parse(txtEntrada_estudiantes.Text);
                string duracion_pelicula = txtDuracion.Text;
                int funciones_diarias = int.Parse(txtFunciones_diarias.Text);
                FuncionesBLL funcion = new FuncionesBLL(id, entrada_adultos, entrada_niños, entrada_estudiantes, duracion_pelicula, funciones_diarias);
                FuncionesDAL create = new FuncionesDAL();
                if (create.updateFuncion(funcion))
                {
                    MessageBox.Show("Los datos fueron actualizados con éxito");
                    fillDgvFunciones();
                    clearTextBox();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar los datos");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Debe seleccionar un dato");
            }
            else
            {
                int id = int.Parse(txtId.Text);
                FuncionesBLL funcion = new FuncionesBLL(id);
                var confirm = MessageBox.Show("¿Estás seguro de eliminar?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    if (funciones.deleteFuncion(funcion))
                    {
                        MessageBox.Show("Dato eliminado con éxito");
                        fillDgvFunciones();
                        clearTextBox();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar");
                    }
                }
            }
        }
    }
}

