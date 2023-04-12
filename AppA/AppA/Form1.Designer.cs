namespace AppA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnEditar = new Button();
            btnEliminar = new Button();
            Consultar = new Button();
            btnGuardar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textNumeroCheque = new TextBox();
            textConceptoPago = new TextBox();
            textCedula = new TextBox();
            textMonto = new TextBox();
            textMontoLetra = new TextBox();
            txtNumeroFactura = new TextBox();
            txtFechaPago = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(891, 254);
            dataGridView1.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(12, 272);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(93, 272);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // Consultar
            // 
            Consultar.Location = new Point(174, 272);
            Consultar.Name = "Consultar";
            Consultar.Size = new Size(111, 23);
            Consultar.TabIndex = 3;
            Consultar.Text = "Consultar Factura";
            Consultar.UseVisualStyleBackColor = true;
            Consultar.Click += Consultar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(909, 224);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(277, 71);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(909, 12);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 5;
            label1.Text = "Número de cheque";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(909, 42);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 6;
            label2.Text = "Concepto de pago";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(909, 71);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 7;
            label3.Text = "Cédula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(909, 99);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 8;
            label4.Text = "Fecha de pago";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(909, 128);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 9;
            label5.Text = "Monto $";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(909, 157);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 10;
            label6.Text = "Monto en letra";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(909, 186);
            label7.Name = "label7";
            label7.Size = new Size(135, 15);
            label7.TabIndex = 11;
            label7.Text = "Num. de factura pagada";
            // 
            // textNumeroCheque
            // 
            textNumeroCheque.Location = new Point(1047, 9);
            textNumeroCheque.Name = "textNumeroCheque";
            textNumeroCheque.Size = new Size(139, 23);
            textNumeroCheque.TabIndex = 12;
            // 
            // textConceptoPago
            // 
            textConceptoPago.Location = new Point(1047, 39);
            textConceptoPago.Name = "textConceptoPago";
            textConceptoPago.Size = new Size(139, 23);
            textConceptoPago.TabIndex = 13;
            // 
            // textCedula
            // 
            textCedula.Location = new Point(1047, 68);
            textCedula.Name = "textCedula";
            textCedula.Size = new Size(139, 23);
            textCedula.TabIndex = 15;
            // 
            // textMonto
            // 
            textMonto.Location = new Point(1047, 125);
            textMonto.Name = "textMonto";
            textMonto.Size = new Size(139, 23);
            textMonto.TabIndex = 17;
            // 
            // textMontoLetra
            // 
            textMontoLetra.Location = new Point(1047, 154);
            textMontoLetra.Name = "textMontoLetra";
            textMontoLetra.Size = new Size(139, 23);
            textMontoLetra.TabIndex = 18;
            // 
            // txtNumeroFactura
            // 
            txtNumeroFactura.Location = new Point(1047, 183);
            txtNumeroFactura.Name = "txtNumeroFactura";
            txtNumeroFactura.Size = new Size(139, 23);
            txtNumeroFactura.TabIndex = 19;
            // 
            // txtFechaPago
            // 
            txtFechaPago.Location = new Point(1047, 96);
            txtFechaPago.Name = "txtFechaPago";
            txtFechaPago.Size = new Size(139, 23);
            txtFechaPago.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 301);
            Controls.Add(txtFechaPago);
            Controls.Add(txtNumeroFactura);
            Controls.Add(textMontoLetra);
            Controls.Add(textMonto);
            Controls.Add(textCedula);
            Controls.Add(textConceptoPago);
            Controls.Add(textNumeroCheque);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(Consultar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Aplicacion A";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnEditar;
        private Button btnEliminar;
        private Button Consultar;
        private Button btnGuardar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textNumeroCheque;
        private TextBox textConceptoPago;
        private TextBox textCedula;
        private TextBox textMonto;
        private TextBox textMontoLetra;
        private TextBox txtNumeroFactura;
        private DateTimePicker txtFechaPago;
    }
}