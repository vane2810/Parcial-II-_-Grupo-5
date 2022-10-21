using Parcial_II___Grupo_5.Properties;
using Parcial_II___Grupo_5.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_II___Grupo_5.DAL
{
    public class FuncionesDAL
    {
        private Database db;
        public FuncionesDAL()
        {
            db = new Database();
        }

        public DataTable getAllFunciones()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = db.getConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Funciones";
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    con.Close();
                    return dt;
                }
            }
            catch
            {
                return dt;
            }
        }

        public bool createFuncione(FuncionesBLL emp)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Funciones (entra_a, entra_n, entra_e , dur_peli, fun_dia) VALUES (@entra_a, @entra_n, @entra_e, @dur_peli, fun_dia);";
                    cmd.Parameters.AddWithValue("@entra_a", emp.Entrada_adultos);
                    cmd.Parameters.AddWithValue("@entra_n", emp.Entrada_niños);
                    cmd.Parameters.AddWithValue("@entra_e", emp.Entrada_estudiantes);
                    cmd.Parameters.AddWithValue("@dur_peli", emp.Duracion_pelicula);
                    cmd.Parameters.AddWithValue("fun_dia", emp.Funciones_diarias);
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.GetBaseException());
                return false;
            }
        }

        public bool updateFuncione(FuncionesBLL emp)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "UPDATE Funciones SET entrada_adultos = @entra_a, entrada_niños = @entra_n, entrada_estudiantes = @entra_e, duracion_pelicula = @dur_peli, funciones_diarias = fun_dia WHERE id = @id);";
                    cmd.Parameters.AddWithValue("@id", emp.Id);
                    cmd.Parameters.AddWithValue("@entra_a", emp.Entrada_adultos);
                    cmd.Parameters.AddWithValue("@entra_n", emp.Entrada_niños);
                    cmd.Parameters.AddWithValue("@entra_e", emp.Entrada_estudiantes);
                    cmd.Parameters.AddWithValue("@dur_peli", emp.Duracion_pelicula);
                    cmd.Parameters.AddWithValue("@fun_dia", emp.Funciones_diarias);
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool deleteFuncione(FuncionesBLL emp)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "DELETE FROM Funciones WHERE id = @id;";
                    cmd.Parameters.AddWithValue("@id", emp.Id);
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
