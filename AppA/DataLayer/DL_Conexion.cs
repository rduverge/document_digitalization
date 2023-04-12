using System.Data.SqlClient;
using System.Data;

namespace DataLayer
{
    public class DL_Conexion
    {
        private SqlConnection Conexion = new SqlConnection("Server=DESKTOP-D495LNS\\SQLEXPRESS;DataBase= RegFac ;Integrated Security=true");

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}