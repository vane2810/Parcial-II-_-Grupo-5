using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_II___Grupo_5.BLL
{
    public class FuncionesBLL
    {
        private int id;
        private int id_salas;
        private int entrada_adultos;
        private int entrada_niños;
        private int entrada_estudiantes;
        private string duracion_pelicula;
        private int funciones_diarias;

        public FuncionesBLL(int id)
        {
            Id = id;
        }

        public FuncionesBLL(int id, int id_salas, int entrada_adultos, int entrada_niños, int entrada_estudiantes, string duracion_pelicula, int funciones_diarias)
        {
            this.id = id;
            this.entrada_adultos = entrada_adultos;
            this.entrada_niños = entrada_niños;
            this.entrada_estudiantes = entrada_estudiantes;
            this.duracion_pelicula = duracion_pelicula;
            this.funciones_diarias = funciones_diarias;
        }

        public int Id { get => id; set => id = value; }
        public int Entrada_adultos { get => entrada_adultos; set => entrada_adultos = value; }
        public int Entrada_niños { get => entrada_niños; set => entrada_niños = value; }
        public int Entrada_estudiantes { get => entrada_estudiantes; set => entrada_estudiantes = value; }
        public string Duracion_pelicula { get => duracion_pelicula; set => duracion_pelicula = value; }
        public int Funciones_diarias { get => funciones_diarias; set => funciones_diarias = value; }
    }
}
