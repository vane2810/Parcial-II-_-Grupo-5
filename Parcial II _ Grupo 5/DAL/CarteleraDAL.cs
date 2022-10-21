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
    public class CarteleraDAL
    {
        private Database db;
        public CarteleraDAL()
        {
            db = new Database();
        }

        public DataTable getAllCartelera()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = db.getConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Cartelera";
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

        public bool createCarteleras(CarteleraBLL emp)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Cartelera (nombre_pelicula, periodo_pelicula, ganancias_funcion , ganancias_diarias, ganancias_totales) VALUES (@nom_peli, @per_peli, @gan_fun, @gan_dia, gan_total);";
                    cmd.Parameters.AddWithValue("@nom_peli", emp.Nombre_pelicula);
                    cmd.Parameters.AddWithValue("@per_peli", emp.Periodo_pelicula);
                    cmd.Parameters.AddWithValue("@gan_fun", emp.Ganancias_funcion);
                    cmd.Parameters.AddWithValue("@gan_dia", emp.Ganancias_diarias);
                    cmd.Parameters.AddWithValue("@gan_total", emp.Ganancias_totales);
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

        public bool updateCarteleras(CarteleraBLL emp)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "UPDATE Cartelera SET nombre_pelicula = @nom_peli, periodo_pelicula = @per_peli, ganancias_funcion = @gan_fun, ganancias_diarias = @gan_dia, ganancias_totales = gan_total WHERE id_funciones = @id);";
                    cmd.Parameters.AddWithValue("@id", emp.Id_funciones);
                    cmd.Parameters.AddWithValue("@nom_peli", emp.Nombre_pelicula);
                    cmd.Parameters.AddWithValue("@per_peli", emp.Periodo_pelicula);
                    cmd.Parameters.AddWithValue("@gan_fun", emp.Ganancias_funcion);
                    cmd.Parameters.AddWithValue("@gan_dia", emp.Ganancias_diarias);
                    cmd.Parameters.AddWithValue("@gan_total", emp.Ganancias_totales);
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

        public bool deleteCarteleras(CarteleraBLL emp)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "DELETE FROM Cartelera WHERE id = @id;";
                    cmd.Parameters.AddWithValue("@id", emp.Id_funciones);
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
