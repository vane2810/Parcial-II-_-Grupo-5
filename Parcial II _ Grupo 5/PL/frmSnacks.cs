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
    public partial class frmSnacks : Form
    {
        SnacksDAL snacks;
        public frmSnacks()
        {
            InitializeComponent();
            snacks = new SnacksDAL();
        }

        private void frmSnacks_Load(object sender, EventArgs e)
        {
            fillDgvSnacks();
        }

        private void fillDgvSnacks()
        {
            dgvSnacks.DataSource = snacks.getAllSnacks();
        }

        private void clearTextBox()
        {
            txtId.Clear();
            txtProducto.Clear();
            txtMarca.Clear();
            txtCompra.Clear();
            txtVenta.Clear();
            txtCantidad.Clear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProducto.Text) || string.IsNullOrEmpty(txtMarca.Text) || string.IsNullOrEmpty(txtCompra.Text )
                || string.IsNullOrEmpty(txtVenta.Text) || string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                string producto = txtProducto.Text;
                string marca = txtMarca.Text;
                double precio_compra = Convert.ToInt32(txtCompra.Text);
                double precio_venta = Convert.ToInt32(txtVenta.Text);
                int cantidad = int.Parse(txtCantidad.Text);
                SnacksBLL snack = new SnacksBLL(0, producto, marca, precio_compra, precio_venta, cantidad);
                if (snacks.createSnack(snack))
                {
                    MessageBox.Show("Los datos se ingresaron con éxito");
                    fillDgvSnacks();
                    clearTextBox();
                }
                else
                {
                    MessageBox.Show("No se pudieron ingresar los datos");
                }
            }
        }
        private void DgvSnacks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtId.Text = dgvSnacks.Rows[index].Cells[0].Value.ToString();
                txtProducto.Text = dgvSnacks.Rows[index].Cells[1].Value.ToString();
                txtMarca.Text = dgvSnacks.Rows[index].Cells[2].Value.ToString();
                txtCompra.Text = dgvSnacks.Rows[index].Cells[3].Value.ToString();
                txtVenta.Text = dgvSnacks.Rows[index].Cells[4].Value.ToString();
                txtCantidad.Text = dgvSnacks.Rows[index].Cells[5].Value.ToString();
            }

        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtProducto.Text) || string.IsNullOrEmpty(txtMarca.Text)
                || string.IsNullOrEmpty(txtCompra.Text)|| string.IsNullOrEmpty(txtVenta.Text) || string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Debe completar todos los campos requeridos");
            }
            else
            {
                int id = int.Parse(txtId.Text);
                string producto = txtProducto.Text;
                string marca = txtMarca.Text;
                double precio_compra = Convert.ToInt32(txtCompra.Text);
                double precio_venta = Convert.ToInt32(txtVenta.Text);
                int cantidad = int.Parse(txtCantidad.Text);
                SnacksBLL snack = new SnacksBLL(id, producto, marca, precio_compra, precio_venta, cantidad);
                SnacksDAL create = new SnacksDAL();
                if (create.updateSnack(snack))
                {
                    MessageBox.Show("Los datos fueron actualizados con éxito");
                    fillDgvSnacks();
                    clearTextBox();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar");
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
                SnacksBLL snack = new SnacksBLL(id);
                var confirm = MessageBox.Show("¿Estás seguro de eliminar?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    if (snacks.deleteSnack(snack))
                    {
                        MessageBox.Show("Dato eliminado con éxito");
                        fillDgvSnacks();
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

