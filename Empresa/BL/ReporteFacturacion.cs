using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    public class ReporteFacturacion
    {
        public int Consecutivo;
        public Cliente Cliente;
        public List<Factura> Historico;
        public double Total;
    }
}
