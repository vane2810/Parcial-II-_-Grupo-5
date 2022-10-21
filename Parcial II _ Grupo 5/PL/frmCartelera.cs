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
    public partial class frmCartelera : Form
    {
        CarteleraDAL cartelera;
        public frmCartelera()
        {
            InitializeComponent();
            cartelera = new CarteleraDAL();
        }
        private void dgvCartelera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fillDgvCartelera();
        }

        private void fillDgvCartelera()
        {
            dgvCartelera.DataSource = cartelera.getAllCartelera();
        }

        private void clearTextBox()
        {
            txtId_funcion.Clear();
            txtNombre_pelicula.Clear();
            txtPeriodo_pelicula.Clear();
            txtGanancias_funcion.Clear();
            txtGanancias_diarias.Clear();
            txtGanancias_totales.Clear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre_pelicula.Text) || string.IsNullOrEmpty(txtPeriodo_pelicula.Text)
                || string.IsNullOrEmpty(txtGanancias_funcion.Text)|| string.IsNullOrEmpty(txtGanancias_diarias.Text) 
                || string.IsNullOrEmpty(txtGanancias_totales.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                string nombre_pelicula = txtNombre_pelicula.Text;
                string periodo_pelicula = txtPeriodo_pelicula.Text;
                double ganancias_funcion = double.Parse(txtGanancias_funcion.Text);
                double ganancias_diarias = double.Parse(txtGanancias_diarias.Text);
                double ganancias_totales = double.Parse(txtGanancias_totales.Text);
                CarteleraBLL carteleras = new CarteleraBLL(0, nombre_pelicula, periodo_pelicula, ganancias_funcion, ganancias_diarias, ganancias_totales);
                if (cartelera.createCarteleras(carteleras))
                {
                    MessageBox.Show("Los datos de cartelera se ingresaron con éxito");
                    fillDgvCartelera();
                    clearTextBox();
                }
                else
                {
                    MessageBox.Show("No se pudieron ingresar los datos de cartelera");
                }
            }
        }
        private void DgvCartelera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtId_funcion.Text = dgvCartelera.Rows[index].Cells[0].Value.ToString();
                txtNombre_pelicula.Text = dgvCartelera.Rows[index].Cells[1].Value.ToString();
                txtPeriodo_pelicula.Text = dgvCartelera.Rows[index].Cells[2].Value.ToString();
                txtGanancias_funcion.Text = dgvCartelera.Rows[index].Cells[3].Value.ToString();
                txtGanancias_diarias.Text = dgvCartelera.Rows[index].Cells[4].Value.ToString();
                txtGanancias_totales.Text = dgvCartelera.Rows[index].Cells[5].Value.ToString();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId_funcion.Text) || string.IsNullOrEmpty(txtNombre_pelicula.Text) 
                || string.IsNullOrEmpty(txtPeriodo_pelicula.Text) || string.IsNullOrEmpty(txtGanancias_funcion.Text) 
                || string.IsNullOrEmpty(txtGanancias_diarias.Text) || string.IsNullOrEmpty(txtGanancias_totales.Text))
            {
                MessageBox.Show("Debe completar todos los campos requeridos");
            }
            else
            {
                int id = int.Parse(txtId_funcion.Text);
                string nombre_pelicula = txtNombre_pelicula.Text;
                string periodo_pelicula = txtPeriodo_pelicula.Text;
                double ganancias_funcion = double.Parse(txtGanancias_funcion.Text);
                double ganancias_diarias = double.Parse(txtGanancias_diarias.Text);
                double ganancias_totales = double.Parse(txtGanancias_totales.Text);
                CarteleraBLL carteleras = new CarteleraBLL(id, nombre_pelicula, periodo_pelicula, ganancias_funcion, ganancias_diarias, ganancias_totales);
                CarteleraDAL create = new CarteleraDAL();
                if (create.updateCarteleras(carteleras))
                {
                    MessageBox.Show("Los datos fueron actualizados con éxito");
                    fillDgvCartelera();
                    clearTextBox();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la cartelera");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId_funcion.Text))
            {
                MessageBox.Show("Debe seleccionar un dato");
            }
            else
            {
                int id = int.Parse(txtId_funcion.Text);
                CarteleraBLL carteleras = new CarteleraBLL(id);
                var confirm = MessageBox.Show("¿Estás seguro de eliminar?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    if (cartelera.deleteCarteleras(carteleras))
                    {
                        MessageBox.Show("Dato eliminado con éxito");
                        fillDgvCartelera();
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

