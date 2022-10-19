using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_II___Grupo_5.BLL
{
    public class CarteleraBLL
    {
        private int id_funciones;
        private string nombre_pelicula;
        private string periodo_pelicula;
        private double ganancias_funcion;
        private double ganancias_diarias;
        private double ganancias_totales;

        public CarteleraBLL(int id_funciones)
        {
            this.id_funciones = id_funciones;
        }

        public CarteleraBLL(int id_funciones, string nombre_pelicula = null, string periodo_pelicula = null, double ganancias_funcion = 0, double ganancias_diarias = 0, double ganancias_totales = 0)
        {
            this.Id_funciones = id_funciones;
            this.Nombre_pelicula = nombre_pelicula;
            this.Periodo_pelicula = periodo_pelicula;
            this.Ganancias_funcion = ganancias_funcion;
            this.Ganancias_diarias = ganancias_diarias;
            this.Ganancias_totales = ganancias_totales;
        }

        public int Id_funciones { get => id_funciones; set => id_funciones = value; }
        public string Nombre_pelicula { get => nombre_pelicula; set => nombre_pelicula = value; }
        public string Periodo_pelicula { get => periodo_pelicula; set => periodo_pelicula = value; }
        public double Ganancias_funcion { get => ganancias_funcion; set => ganancias_funcion = value; }
        public double Ganancias_diarias { get => ganancias_diarias; set => ganancias_diarias = value; }
        public double Ganancias_totales { get => ganancias_totales; set => ganancias_totales = value; }
    }
}
