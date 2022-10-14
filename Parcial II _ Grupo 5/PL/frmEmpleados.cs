﻿using Parcial_II___Grupo_5.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_II___Grupo_5
{
    public partial class Form1 : Form
    {
        EmpleadosDAL empleados;

            
        

        public frmEmpleados()
        {
            InitializeComponent();
            this.sedes = new SedesDAL();
            this.empleados = new EmpleadosDAL();
            this.cargos = new CargosDAL();
        }

        private void listSedes()
        {
            cmbSedes.DataSource = sedes.getAllSedes();
            cmbSedes.DisplayMember = "nombre";
            cmbSedes.ValueMember = "id";
            cmbSedes.SelectedValue = 0;
        }

        private void listCargos()
        {
            cmbCargo.DataSource = cargos.getAllCargos();
            cmbCargo.DisplayMember = "cargo";
            cmbCargo.ValueMember = "id";
            cmbCargo.SelectedValue = 0;
        }

        private void DgvEmpleados()
        {
           DgvEmpleados.DataSource = empleados.getAllEmpleados();
        }

        private void clearTextBox()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtDui.Clear();
            txtId.Clear();
            cmbSedes.SelectedValue = 0;
            cmbCargo.SelectedValue = 0;
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            listSedes();
            listCargos();
            fillDgvEmpleados();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombres.Text) || string.IsNullOrEmpty(txtApellidos.Text)
                || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtTelefono.Text)
                || string.IsNullOrEmpty(txtDui.Text) || string.IsNullOrEmpty(cmbSedes.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                string nombres = txtNombres.Text;
                string apellidos = txtApellidos.Text;
                string email = txtEmail.Text;
                string telefono = txtTelefono.Text;
                string dui = txtDui.Text;
                int idSede = Convert.ToInt32(cmbSedes.SelectedValue);
                int idCargo = Convert.ToInt32(cmbCargo.SelectedValue);
                EmpleadosBLL emp = new EmpleadosBLL(0, nombres, apellidos, email, telefono, dui);
                SedesBLL sede = new SedesBLL(idSede);
                CargosBLL cargo = new CargosBLL(idCargo);
                if (empleados.createEmpleado(emp, sede, cargo))
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtNombres.Text) || string.IsNullOrEmpty(txtApellidos.Text)
                || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtTelefono.Text)
                || string.IsNullOrEmpty(txtDui.Text) || string.IsNullOrEmpty(cmbSedes.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                int id = Convert.ToInt32(txtId.Text);
                string nombres = txtNombres.Text;
                string apellidos = txtApellidos.Text;
                string email = txtEmail.Text;
                string telefono = txtTelefono.Text;
                string dui = txtDui.Text;
                int idSede = Convert.ToInt32(cmbSedes.SelectedValue);
                int idCargo = Convert.ToInt32(cmbCargo.SelectedValue);
                EmpleadosBLL emp = new EmpleadosBLL(id, nombres, apellidos, email, telefono, dui);
                SedesBLL sede = new SedesBLL(idSede);
                CargosBLL cargo = new CargosBLL(idCargo);
                if (empleados.updateEmpleado(emp, sede, cargo))
                {
                    MessageBox.Show("Se actualizaron los datos del empleado");
                    fillDgvEmpleados();
                    clearTextBox();
                }
                else
                {
                    MessageBox.Show("No se pudieron actualizar los datos");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Debe seleccionar un empleado");
            }
            else
            {
                int id = Convert.ToInt32(txtId.Text);
                EmpleadosBLL emp = new EmpleadosBLL(id);
                var confirm = MessageBox.Show("¿Estás seguro de eliminar este empleado?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    if (empleados.deleteEmpleado(emp))
                    {
                        MessageBox.Show("Datos del empleado eliminado");
                        fillDgvEmpleados();
                        clearTextBox();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar ");
                    }
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
                txtEmail.Text = dgvEmpleados.Rows[index].Cells[3].Value.ToString();
                txtTelefono.Text = dgvEmpleados.Rows[index].Cells[4].Value.ToString();
                cmbSedes.SelectedValue = Convert.ToInt32(dgvEmpleados.Rows[index].Cells[5].Value);
                txtDui.Text = dgvEmpleados.Rows[index].Cells[6].Value.ToString();
                cmbCargo.SelectedValue = Convert.ToInt32(dgvEmpleados.Rows[index].Cells[7].Value);
            }
        }
    }
}
