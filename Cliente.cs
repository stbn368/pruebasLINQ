using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebasLINQ
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
    }

    public class Pedido
    {
        public int PedidoId { get; set; }
        public int ClienteId { get; set; }
        public string DetallesPedido { get; set; }
        public DateTime FechaPedido { get; set; }
    }

    public class DetallePedido
    {
        public int PedidoId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
    }
    public class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int ProductoId { get; set; }
    }
}
