using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneGroup.Class
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public decimal ValorPedidos { get; set; }
        public int IdCliente { get; set; }
        public DateTime DataPedido { get; set; }
    }
}
