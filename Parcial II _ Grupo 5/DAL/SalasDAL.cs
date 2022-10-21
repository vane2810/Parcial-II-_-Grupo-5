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
    public class SalasDAL
    {
        private Database db;
        public SalasDAL()
        {
            db = new Database();
        }

        public DataTable getAllSalas()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = db.getConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Salas";
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

        public bool createSala(SalasBLL emp)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Salas (numero_sala, asientos_totales, asientos_ocupados, id_empleados, horario_limpieza) VALUES (@n_s, @a_t, @a_o, @id_e, @ho_l);";
                    cmd.Parameters.AddWithValue("@n_s", emp.Numero_sala);
                    cmd.Parameters.AddWithValue("@a_t", emp.Asientos_totales);
                    cmd.Parameters.AddWithValue("@a_o", emp.Asientos_ocupados);
                    cmd.Parameters.AddWithValue("@id_e", emp.Id_empleados);
                    cmd.Parameters.AddWithValue("@ho_l", emp.Horario_limpieza);
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

        public bool updateSala(SalasBLL emp)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "UPDATE Salas SET numero_sala = @n_s, asientos_totales = @a_t, asientos_ocupados = @a_o, id_empleados = @id_e, horario_limpieza = ho_l WHERE id = @id);";
                    cmd.Parameters.AddWithValue("@id", emp.Id);
                    cmd.Parameters.AddWithValue("@n_s", emp.Numero_sala);
                    cmd.Parameters.AddWithValue("@a_t", emp.Asientos_totales);
                    cmd.Parameters.AddWithValue("@a_o", emp.Asientos_ocupados);
                    cmd.Parameters.AddWithValue("@id_e", emp.Id_empleados);
                    cmd.Parameters.AddWithValue("@ho_l", emp.Horario_limpieza);
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

        public bool deleteSala(SalasBLL emp)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "DELETE FROM Salas WHERE id = @id;";
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
