using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_II___Grupo_5.BLL
{
    public class EmpleadosBLL
    {
        private int id;
        private string nombres;
        private string apellidos;
        private string cargo;
        private string telefono;

        public EmpleadosBLL(int id)
        {
            this.id = id;
        }

        public EmpleadosBLL(int id, string nombres, string apellidos, string cargo, string telefono)
        {
            this.id = id;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.cargo = cargo;
            this.telefono = telefono;
        }

        public int Id { get => id; set => id = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
