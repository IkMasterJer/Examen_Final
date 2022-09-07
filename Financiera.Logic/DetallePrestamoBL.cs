using Financiera.Data;
using Financiera.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Logic
{
    public static class DetallePrestamoBL
    {
        public static List<DetallePrestamo> Listar()
        {
            var detallePrestamoData = new DetallePrestamoData();
            return detallePrestamoData.Listar();
        }
    }
}
