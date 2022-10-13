using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_II___Grupo_5.BLL
{
    public class SalasBLL
    {
        private int id;
        private int numero_sala;
        private int asientos_totales;
        private int asientos_ocupados;
        private int id_empleados;
        private string horario_limpieza;

        public SalasBLL(int id)
        {
            this.id = id;
        }

        public SalasBLL(int id, int numero_sala, int asientos_totales, int asientos_ocupados, int id_empleados, string horario_limpieza)
        {
            this.id = id;
            this.numero_sala = numero_sala;
            this.asientos_totales = asientos_totales;
            this.asientos_ocupados = asientos_ocupados;
            this.id_empleados = id_empleados;
            this.horario_limpieza = horario_limpieza;
        }

        public int Id { get => id; set => id = value; }
        public int Numero_sala { get => numero_sala; set => numero_sala = value; }
        public int Asientos_totales { get => asientos_totales; set => asientos_totales = value; }
        public int Asientos_ocupados { get => asientos_ocupados; set => asientos_ocupados = value; }
        public int Id_empleados { get => id_empleados; set => id_empleados = value; }
        public string Horario_limpieza { get => horario_limpieza; set => horario_limpieza = value; }
    }
}
