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
    public class SnacksDAL
    {
        private Database db;
        public SnacksDAL()
        {
            db = new Database();
        }

        public DataTable getAllSnacks()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = db.getConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Snacks";
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

        public bool createSnack(SnacksBLL emp)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Snacks (producto, marca , precio_compra, precio_venta, cantidad) VALUES (@pro, @mar, @p_c, @p_v, can);";
                    cmd.Parameters.AddWithValue("@pro", emp.Producto);
                    cmd.Parameters.AddWithValue("@mar", emp.Marca);
                    cmd.Parameters.AddWithValue("@p_c", emp.Precio_compra);
                    cmd.Parameters.AddWithValue("@p_v", emp.Precio_venta);
                    cmd.Parameters.AddWithValue("@can", emp.Cantidad);
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

        public bool updateSnack(SnacksBLL emp)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "UPDATE Snacks SET producto = @pro, marca = @mar, precio_compra = @p_c, precio_venta = @p_v, cantidad = @can WHERE id = @id);";
                    cmd.Parameters.AddWithValue("@id", emp.Id);
                    cmd.Parameters.AddWithValue("@pro", emp.Producto);
                    cmd.Parameters.AddWithValue("@mar", emp.Marca);
                    cmd.Parameters.AddWithValue("@precio_compra", emp.Precio_compra);
                    cmd.Parameters.AddWithValue("@precio_venta", emp.Precio_venta);
                    cmd.Parameters.AddWithValue("@cant", emp.Cantidad);
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

        public bool deleteSnack(SnacksBLL emp)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "DELETE FROM Snacks WHERE id = @id;";
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
