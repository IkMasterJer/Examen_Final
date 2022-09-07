using Financiera.Dominio;
using Financiera.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financiera.AppWin
{
    public partial class frmConsultaPrestamo : Form
    {
        Prestamo prestamo;
        public frmConsultaPrestamo(Prestamo prestamo)
        {
            this.prestamo = prestamo;
            InitializeComponent();
            cargarDatos();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void iniciarFormulario(object sender, EventArgs e)
        {
            cargarDatos();
            btnconsulta.Visible = prestamo.ID > 0;
           
        }

        private void cargarDatos()
        {
            var listado = ClienteBL.Listar();
            listado.Insert(0, new Cliente
            {
                Nombres = "--SELECCIONE--"
            });
            cboCliente.DataSource = listado;
            cboCliente.DisplayMember = "NombreCompleto";
            cboCliente.ValueMember = "ID";
        }

        private void asignarObjeto()
        {
            prestamo.IdCliente = int.Parse(cboCliente.SelectedValue.ToString());
            prestamo.FechaDeposito = dpFechaDeposito.Value;
            prestamo.Importe = decimal.Parse(txtimporte.Text);
            prestamo.Tasa = decimal.Parse(txttasa.Text);
            prestamo.Plazo = int.Parse(txtplazo.Text);
        }

    }
}
