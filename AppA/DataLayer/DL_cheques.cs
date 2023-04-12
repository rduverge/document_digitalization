using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataLayer;
using System.Data.SqlTypes;

public class Dl_cheques
{
    private DL_Conexion conexion = new DL_Conexion();

    SqlDataReader leer;
    DataTable tabla = new DataTable();
    SqlCommand comando = new SqlCommand();

    public DataTable Mostrar()
    {

        comando.Connection = conexion.AbrirConexion();
        comando.CommandText = "MostrarCheques";
        comando.CommandType = CommandType.StoredProcedure;
        leer = comando.ExecuteReader();
        tabla.Load(leer);
        conexion.CerrarConexion();
        return tabla;

    }

    public void Insertar(string NumeroCheque, string ConceptoPago, string Cedula, DateTime FechaPago, double MontoNumero,string MontoLetra, string FacturaPagada)
    {
        comando.Connection = conexion.AbrirConexion();
        comando.CommandText = "InsetarCheque";
        comando.CommandType = CommandType.StoredProcedure;
        comando.Parameters.AddWithValue("@NumeroCheque", NumeroCheque);
        comando.Parameters.AddWithValue("@ConceptoPago", ConceptoPago);
        comando.Parameters.AddWithValue("@Cedula", Cedula);
        comando.Parameters.AddWithValue("@FechaPago", FechaPago);
        comando.Parameters.AddWithValue("@MontoNumero", MontoNumero);
        comando.Parameters.AddWithValue("@MontoLetra", MontoLetra);
        comando.Parameters.AddWithValue("@FacturaPagada", FacturaPagada);

        comando.ExecuteNonQuery();

        comando.Parameters.Clear();
        conexion.CerrarConexion();

    }

    public void Editar(int IdCheque, string NumeroCheque, string ConceptoPago, string Cedula, DateTime FechaPago, double MontoNumero, string MontoLetra, string FacturaPagada)
    {
        comando.Connection = conexion.AbrirConexion();
        comando.CommandText = "EditarCheque";
        comando.CommandType = CommandType.StoredProcedure;
        comando.Parameters.AddWithValue("@NumeroCheque", NumeroCheque);
        comando.Parameters.AddWithValue("@ConceptoPago", ConceptoPago);
        comando.Parameters.AddWithValue("@Cedula", Cedula);
        comando.Parameters.AddWithValue("@FechaPago", FechaPago);
        comando.Parameters.AddWithValue("@MontoNumero", MontoNumero);
        comando.Parameters.AddWithValue("@MontoLetra", MontoLetra);
        comando.Parameters.AddWithValue("@FacturaPagada", FacturaPagada);
        comando.Parameters.AddWithValue("@id", IdCheque);

        comando.ExecuteNonQuery();

        comando.Parameters.Clear();
        conexion.CerrarConexion();
    }

    public void Eliminar(int IdCheque)
    {
        comando.Connection = conexion.AbrirConexion();
        comando.CommandText = "EliminarCheque";
        comando.CommandType = CommandType.StoredProcedure;
        comando.Parameters.AddWithValue("@idpro", IdCheque);

        comando.ExecuteNonQuery();

        comando.Parameters.Clear();
        conexion.CerrarConexion();
    }

}