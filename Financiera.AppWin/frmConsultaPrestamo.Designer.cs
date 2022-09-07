namespace Financiera.AppWin
{
    partial class frmConsultaPrestamo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnconsulta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txttasa = new System.Windows.Forms.TextBox();
            this.txtplazo = new System.Windows.Forms.TextBox();
            this.txtimporte = new System.Windows.Forms.TextBox();
            this.dgvdatos = new System.Windows.Forms.DataGridView();
            this.colNumcouta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFvenc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInteres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPagoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboprestamo = new System.Windows.Forms.ComboBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnconsulta
            // 
            this.btnconsulta.Location = new System.Drawing.Point(350, 29);
            this.btnconsulta.Name = "btnconsulta";
            this.btnconsulta.Size = new System.Drawing.Size(83, 23);
            this.btnconsulta.TabIndex = 0;
            this.btnconsulta.Text = "CONSULTAR";
            this.btnconsulta.UseVisualStyleBackColor = true;
            this.btnconsulta.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prestamo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "RESULTADO DE LA CONSULTA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Importe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Plazo (Meses)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tasa de Interes";
            // 
            // txttasa
            // 
            this.txttasa.Location = new System.Drawing.Point(337, 142);
            this.txttasa.Name = "txttasa";
            this.txttasa.Size = new System.Drawing.Size(113, 20);
            this.txttasa.TabIndex = 8;
            // 
            // txtplazo
            // 
            this.txtplazo.Location = new System.Drawing.Point(101, 171);
            this.txtplazo.Name = "txtplazo";
            this.txtplazo.Size = new System.Drawing.Size(119, 20);
            this.txtplazo.TabIndex = 9;
            // 
            // txtimporte
            // 
            this.txtimporte.Location = new System.Drawing.Point(79, 138);
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.Size = new System.Drawing.Size(141, 20);
            this.txtimporte.TabIndex = 10;
            // 
            // dgvdatos
            // 
            this.dgvdatos.AllowUserToAddRows = false;
            this.dgvdatos.AllowUserToDeleteRows = false;
            this.dgvdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumcouta,
            this.colFvenc,
            this.colCuota,
            this.colInteres,
            this.colPagoTotal,
            this.colSaldo});
            this.dgvdatos.Location = new System.Drawing.Point(12, 221);
            this.dgvdatos.Name = "dgvdatos";
            this.dgvdatos.ReadOnly = true;
            this.dgvdatos.Size = new System.Drawing.Size(645, 183);
            this.dgvdatos.TabIndex = 12;
            // 
            // colNumcouta
            // 
            this.colNumcouta.HeaderText = "Num";
            this.colNumcouta.Name = "colNumcouta";
            this.colNumcouta.ReadOnly = true;
            // 
            // colFvenc
            // 
            this.colFvenc.HeaderText = "Fecha Vencimiento";
            this.colFvenc.Name = "colFvenc";
            this.colFvenc.ReadOnly = true;
            // 
            // colCuota
            // 
            this.colCuota.HeaderText = "Cuota";
            this.colCuota.Name = "colCuota";
            this.colCuota.ReadOnly = true;
            // 
            // colInteres
            // 
            this.colInteres.HeaderText = "Interes";
            this.colInteres.Name = "colInteres";
            this.colInteres.ReadOnly = true;
            // 
            // colPagoTotal
            // 
            this.colPagoTotal.HeaderText = "Pago Total";
            this.colPagoTotal.Name = "colPagoTotal";
            this.colPagoTotal.ReadOnly = true;
            // 
            // colSaldo
            // 
            this.colSaldo.HeaderText = "Saldo";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.ReadOnly = true;
            // 
            // cboprestamo
            // 
            this.cboprestamo.FormattingEnabled = true;
            this.cboprestamo.Location = new System.Drawing.Point(79, 29);
            this.cboprestamo.Name = "cboprestamo";
            this.cboprestamo.Size = new System.Drawing.Size(252, 21);
            this.cboprestamo.TabIndex = 13;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(79, 102);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(141, 20);
            this.txtnombre.TabIndex = 14;
            // 
            // frmConsultaPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 420);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.cboprestamo);
            this.Controls.Add(this.dgvdatos);
            this.Controls.Add(this.txtimporte);
            this.Controls.Add(this.txtplazo);
            this.Controls.Add(this.txttasa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnconsulta);
            this.Name = "frmConsultaPrestamo";
            this.Text = "frmConsultaPrestamo";
            this.Load += new System.EventHandler(this.iniciarFormulario);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttasa;
        private System.Windows.Forms.TextBox txtplazo;
        private System.Windows.Forms.TextBox txtimporte;
        private System.Windows.Forms.DataGridView dgvdatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumcouta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFvenc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInteres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPagoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaldo;
        private System.Windows.Forms.ComboBox cboprestamo;
        private System.Windows.Forms.TextBox txtnombre;
    }
}