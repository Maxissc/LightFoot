using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LightFoot.Dtos.CompraVirtual
{
    public class NuevaVentaRequest
    {
        //(id item, id cliente, cantidad, fecha requerida, precio).
        public int IdItem { get; set; }
        public int IdCliente { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public double Precio { get; set; }
    }
}
