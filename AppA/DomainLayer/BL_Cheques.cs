using DataLayer;
using System.Data;
using System.Data.SqlTypes;

namespace DomainLayer
{
    public class BL_Cheques
    {
        private Dl_cheques objetoCD = new Dl_cheques();
        public DataTable MostrarCheq()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarCheq(string NumeroCheque, string ConceptoPago, string Cedula, string FechaPago, string MontoNumero, string MontoLetra, string FacturaPagada)
        {
            objetoCD.Insertar(NumeroCheque, ConceptoPago, Cedula, DateTime.Parse(FechaPago), Convert.ToDouble(MontoNumero), MontoLetra, FacturaPagada);
        }
        public void EditarCheq(string IdCheque, string NumeroCheque, string ConceptoPago, string Cedula, string FechaPago, string MontoNumero, string MontoLetra, string FacturaPagada)
        {
            objetoCD.Editar(Convert.ToInt32(IdCheque), NumeroCheque, ConceptoPago, Cedula, DateTime.Parse(FechaPago), Convert.ToDouble(MontoNumero), MontoLetra, FacturaPagada);
        }
        public void EliminarCheq(string IdCheque)
        {
            objetoCD.Eliminar(Convert.ToInt32(IdCheque));
        }
    }
}