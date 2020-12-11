using System;
using System.Collections.Generic;
using System.Text;

namespace LojaCompreAqui.Business.Models
{
    public class Pedido : Entity
    {
        public Guid ClienteId { get; set; }
        public DateTime DataPedido { get; set; }

        public Cliente Cliente { get; set; }

        public IEnumerable<ItemPedido> ItensPedido { get; set; }
    }
}
