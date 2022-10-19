using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_II___Grupo_5.BLL
{
    public class SnacksBLL
    {
        private int id;
        private string producto;
        private string marca;
        private double precio_compra;
        private double precio_venta;
        private int cantidad;

        public SnacksBLL(int id)
        {
            this.id = id;
        }

        public SnacksBLL(int id, string producto, string marca, double precio_compra, double precio_venta, int cantidad)
        {
            this.id = id;
            this.producto = producto;
            this.marca = marca;
            this.precio_compra = precio_compra;
            this.precio_venta = precio_venta;
            this.cantidad = cantidad;
        }

        public int Id { get => id; set => id = value; }
        public string Producto { get => producto; set => producto = value; }
        public string Marca { get => marca; set => marca = value; }
        public double Precio_compra { get => precio_compra; set => precio_compra = value; }
        public double Precio_venta { get => precio_venta; set => precio_venta = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
