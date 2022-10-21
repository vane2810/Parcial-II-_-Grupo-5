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
    public partial class frmSalas : Form
    {
        SalasDAL salas;
        public frmSalas()
        {
            InitializeComponent();
            salas = new SalasDAL();
        }

        private void dgvSalas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fillDgvSalas();
        }

        private void fillDgvSalas()
        {
            dgvSalas.DataSource = salas.getAllSalas();
        }

        private void clearTextBox()
        {
            txtId.Clear();
            txtSala.Clear();
            txtAsientos_totales.Clear();
            txtAsientos_ocupados.Clear();
            txtId_empleados.Clear();
            txtHorario_limpieza.Clear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSala.Text) || string.IsNullOrEmpty(txtAsientos_totales.Text)
                || string.IsNullOrEmpty(txtAsientos_ocupados.Text) || string.IsNullOrEmpty(txtId_empleados.Text)
                || string.IsNullOrEmpty(txtHorario_limpieza.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                int sala_n = int.Parse(txtSala.Text);
                int asientos_totales = int.Parse(txtAsientos_totales.Text);
                int asientos_ocupados = int.Parse(txtAsientos_ocupados.Text);
                int id_empleados = int.Parse(txtId_empleados.Text);
                string horarios_limpieza = txtHorario_limpieza.Text;
                SalasBLL sala = new SalasBLL(0, sala_n, asientos_totales, asientos_ocupados, id_empleados, horarios_limpieza);
                if (salas.createSala(sala))
                {
                    MessageBox.Show("Los datos se ingresaron con éxito");
                    fillDgvSalas();
                    clearTextBox();
                }
                else
                {
                    MessageBox.Show("No se pudieron ingresar los datos");
                }
            }
        }
        private void DgvSalas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtId.Text = dgvSalas.Rows[index].Cells[0].Value.ToString();
                txtSala.Text = dgvSalas.Rows[index].Cells[1].Value.ToString();
                txtAsientos_totales.Text = dgvSalas.Rows[index].Cells[2].Value.ToString();
                txtAsientos_ocupados.Text = dgvSalas.Rows[index].Cells[3].Value.ToString();
                txtId_empleados.Text = dgvSalas.Rows[index].Cells[4].Value.ToString();
                txtHorario_limpieza.Text = dgvSalas.Rows[index].Cells[5].Value.ToString();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtSala.Text)
                || string.IsNullOrEmpty(txtAsientos_totales.Text) || string.IsNullOrEmpty(txtAsientos_ocupados.Text)
                || string.IsNullOrEmpty(txtId_empleados.Text) || string.IsNullOrEmpty(txtHorario_limpieza.Text))
            {
                MessageBox.Show("Debe completar todos los campos requeridos");
            }
            else
            {
                int id = int.Parse(txtId.Text);
                int sala_n = int.Parse(txtSala.Text);
                int asientos_totales = int.Parse(txtAsientos_totales.Text);
                int asientos_ocupados = int.Parse(txtAsientos_ocupados.Text);
                int id_empleados = int.Parse(txtId_empleados.Text);
                string horarios_limpieza = txtHorario_limpieza.Text;
                SalasBLL sala = new SalasBLL(id, sala_n , asientos_totales, asientos_ocupados, id_empleados, horarios_limpieza);
                SalasDAL create = new SalasDAL();
                if (create.updateSala(sala))
                {
                    MessageBox.Show("Los datos fueron actualizados con éxito");
                    fillDgvSalas();
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
                SalasBLL sala = new SalasBLL(id);
                var confirm = MessageBox.Show("¿Estás seguro de eliminar?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    if (salas.deleteSala(sala))
                    {
                        MessageBox.Show("Dato eliminado con éxito");
                        fillDgvSalas();
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

