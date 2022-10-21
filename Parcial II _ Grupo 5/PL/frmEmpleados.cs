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
    public partial class frmEmpleados : Form
    {
        EmpleadosDAL empleados;
        
        public frmEmpleados()
        {
            InitializeComponent();
            empleados = new EmpleadosDAL();
        }
        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            fillDgvEmpleados();
        }
        private void fillDgvEmpleados()
        {
            dgvEmpleados.DataSource = empleados.getAllEmpleados();
        }
        private void clearTextBox()
        {
            txtId.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCargo.Clear();
            txtTelefono.Clear();
        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombres.Text) || string.IsNullOrEmpty(txtApellidos.Text)
                || string.IsNullOrEmpty(txtCargo.Text) || string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                string nombre = txtNombres.Text;
                string apellidos = txtApellidos.Text;
                string cargo = txtCargo.Text;
                string telefono = txtTelefono.Text;
                EmpleadosBLL emp= new EmpleadosBLL(0, nombre, apellidos, cargo, telefono);
                if (empleados.createEmpleado(emp))
                {
                    MessageBox.Show("Empleado registrado con éxito");
                    fillDgvEmpleados();
                    clearTextBox();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar al empleado");
                }
            }
        }
        private void dgvEmpleados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtId.Text = dgvEmpleados.Rows[index].Cells[0].Value.ToString();
                txtNombres.Text = dgvEmpleados.Rows[index].Cells[1].Value.ToString();
                txtApellidos.Text = dgvEmpleados.Rows[index].Cells[2].Value.ToString();
                txtCargo.Text = dgvEmpleados.Rows[index].Cells[3].Value.ToString();
                txtTelefono.Text = dgvEmpleados.Rows[index].Cells[4].Value.ToString();
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtNombres.Text)
                || string.IsNullOrEmpty(txtCargo.Text) || string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Debe completar todos los campos requeridos");
            }
            else
            {
                int id = int.Parse(txtId.Text);
                string nombres = txtNombres.Text;
                string apellidos = txtApellidos.Text;
                string cargo = txtCargo.Text;
                string telefono = txtTelefono.Text;
                EmpleadosBLL emp = new EmpleadosBLL(id, nombres, apellidos, cargo, telefono);
                EmpleadosDAL create = new EmpleadosDAL();
                if (create.updateEmpleado(emp))
                {
                    MessageBox.Show("Empleados actualizados con éxito");
                    fillDgvEmpleados();
                    clearTextBox();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar los datos de los empleados");
                }
            }


        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Debe seleccionar una sede");
            }
            else
            {
                int id = int.Parse(txtId.Text);
                EmpleadosBLL emp = new EmpleadosBLL(id);
                var confirm = MessageBox.Show("¿Estás seguro de eliminar esta sede?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    if (empleados.deleteEmpleado(emp))
                    {
                        MessageBox.Show("Sede eliminada con éxito");
                        fillDgvEmpleados();
                        clearTextBox();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la sede");
                    }
                }
            }

        }

    }
}


        