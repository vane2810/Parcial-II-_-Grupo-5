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
        SalasDAL salas;
        FuncionesDAL funciones;
        CarteleraDAL cartelera;
        SnacksDAL snacks;

        public frmEmpleados()
        {
            InitializeComponent();
            this.empleados = new EmpleadosDAL();
            this.salas = new SalasDAL();
            this.funciones = new FuncionesDAL();
            this.cartelera = new CarteleraDAL();
            this.snacks = new SnacksDAL();
        }
    }
}


        