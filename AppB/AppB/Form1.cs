using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace AppB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] param = Environment.GetCommandLineArgs();
            Cedula.Text = param[1];
            getBill(Cedula.Text);
        }

        private void getBill(string sCedula)
        {
            try
            {
                var lCadConexion = System.Configuration.ConfigurationManager.ConnectionStrings["RegFacConString"].ConnectionString;
                string sSQL = "select FacturaPagada from Cheque where Cedula = '" + sCedula + "' order by Cedula ";
                using (SqlConnection ocon = new SqlConnection(lCadConexion))
                using (SqlCommand oda = new SqlCommand(sSQL, ocon))
                {
                    ocon.Open();
                    string NumeroFactura = (string)oda.ExecuteScalar();
                    Image Factura = Image.FromFile("c:\\Users\\Rolando\\Pictures\\" + NumeroFactura + ".jpg");
                    pictureBox1.Image = Factura;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar datos: " + ex.Message);
            }
        }
    }
}