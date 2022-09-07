using Financiera.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Data
{
    public class DetallePrestamoData
    {
        string cadenaConexion = "server=localhost; database=Final; integrated security=true";
        public List<DetallePrestamo> Listar()
        {
            var listado = new List<DetallePrestamo>();
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (var comando = new SqlCommand("Select * From DetallePrestamo", conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector != null && lector.HasRows)
                        {
                            DetallePrestamo DetallePrestamo;
                            while (lector.Read())
                            {
                                DetallePrestamo = new DetallePrestamo();
                                DetallePrestamo.ID = int.Parse(lector[0].ToString());
                                DetallePrestamo.IdPrestamo = int.Parse(lector[1].ToString());
                                DetallePrestamo.NumeroCuota = int.Parse(lector[2].ToString());
                                DetallePrestamo.ImporteCuota = Decimal.Parse(lector[3].ToString());
                                DetallePrestamo.ImporteInteres = decimal.Parse(lector[4].ToString());
                                DetallePrestamo.FechaVencimiento = DateTime.Parse(lector[5].ToString());
                                DetallePrestamo.Estado = lector[6].ToString() == "1" ? true : false;

                                listado.Add(DetallePrestamo);
                            }
                        }
                    }
                }
            }
            return listado;
        }

    }
}
