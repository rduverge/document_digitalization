using DomainLayer;
using System.Diagnostics;
using System;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppA
{
    public partial class Form1 : Form
    {
        BL_Cheques objetoCN = new BL_Cheques();
        private string IdCheque = null;
        private bool Editar = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarCheques()
        {

            BL_Cheques objeto = new BL_Cheques();
            dataGridView1.DataSource = objeto.MostrarCheq();
        }

        private void limpiarForm()
        {
            textNumeroCheque.Clear();
            textConceptoPago.Text = "";
            textCedula.Clear();
            txtFechaPago.ResetText();
            textMonto.Clear();
            textMontoLetra.Clear();
            txtNumeroFactura.Clear();

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            //INSERTAR
            if (Editar == false)
            {
                try
                {
                    objetoCN.InsertarCheq(textNumeroCheque.Text, textConceptoPago.Text, textCedula.Text, txtFechaPago.Text, textMonto.Text, textMontoLetra.Text, txtNumeroFactura.Text);
                    MessageBox.Show("Dato agregado correctamente");
                    MostrarCheques();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar: " + ex);
                }
            }
            //EDITAR
            if (Editar == true)
            {

                try
                {
                    objetoCN.EditarCheq(IdCheque, textNumeroCheque.Text, textConceptoPago.Text, textCedula.Text, txtFechaPago.Text, textMonto.Text, textMontoLetra.Text, txtNumeroFactura.Text);
                    MessageBox.Show("Editado correctamente");
                    MostrarCheques();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar datos: " + ex);
                }
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                textNumeroCheque.Text = dataGridView1.CurrentRow.Cells["NumeroCheque"].Value.ToString();
                textConceptoPago.Text = dataGridView1.CurrentRow.Cells["ConceptoPago"].Value.ToString();
                textCedula.Text = dataGridView1.CurrentRow.Cells["Cedula"].Value.ToString();
                txtFechaPago.Text = dataGridView1.CurrentRow.Cells["FechaPago"].Value.ToString();
                textMonto.Text = dataGridView1.CurrentRow.Cells["MontoNumero"].Value.ToString();
                textMontoLetra.Text = dataGridView1.CurrentRow.Cells["MontoLetra"].Value.ToString();
                txtNumeroFactura.Text = dataGridView1.CurrentRow.Cells["FacturaPagada"].Value.ToString();
                IdCheque = dataGridView1.CurrentRow.Cells["IdCheque"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                IdCheque = dataGridView1.CurrentRow.Cells["IdCheque"].Value.ToString();
                objetoCN.EliminarCheq(IdCheque);
                MessageBox.Show("Eliminado correctamente");
                MostrarCheques();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            MostrarCheques();
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            try
            {
                string sCedula = dataGridView1.CurrentRow.Cells["Cedula"].Value.ToString(); ;
                System.Console.WriteLine(sCedula);
                ProcessStartInfo processInfo = new ProcessStartInfo();
                processInfo.FileName = "cmd.exe";
                processInfo.Arguments = "/c C:\\Users\\Rolando\\Desktop\\AppB\\AppB\\bin\\Debug\\net6.0-windows\\AppB " + sCedula;
                processInfo.RedirectStandardError = true;
                Process process = new Process();
                process.StartInfo = processInfo;
                process.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}