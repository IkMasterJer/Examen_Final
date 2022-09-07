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
        Cliente cliente;
        DetallePrestamo detprestamo;
        public frmConsultaPrestamo()
        {
            
            InitializeComponent();
            
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
            if (prestamo.ID > 0)
            {
                asignarcontroles();
            }

        }

        private void cargarDatos()
        {
            var listado = PrestamoBL.Listar();
            var listadodet = DetallePrestamoBL.Listar();
            listado.Insert(0, new Prestamo
            {
                Numero = "--SELECCIONE--"
            });
            cboprestamo.DataSource = listado;
            cboprestamo.DisplayMember = "Numero";
            cboprestamo.ValueMember = "ID";

            dgvdatos.Rows.Clear();
            foreach (var detprestamo in listadodet)
            {
                dgvdatos.Rows.Add(detprestamo.NumeroCuota, detprestamo.FechaVencimiento, detprestamo.ImporteCuota, detprestamo.ImporteInteres);
            }
        }

        private void asignarcontroles()
        {
            cboprestamo.SelectedValue = prestamo.Numero;
            txtnombre.Text = prestamo.IdCliente;
            decimal.Parse(txtimporte.Text = prestamo.Importe.ToString());
            decimal.Parse(txtplazo.Text = prestamo.Plazo.ToString());
            int.Parse(txttasa.Text = prestamo.Tasa.ToString());

            /*prestamo.Numero = cboprestamo.SelectedValue.ToString();
            cliente.Nombres = txtnombre.Text;
            prestamo.Importe = decimal.Parse(txtimporte.Text);
            prestamo.Plazo = decimal.Parse(txtplazo.Text);
            prestamo.Tasa = int.Parse(txttasa.Text.ToString());*/

        }       

    }
}
