using System;
using System.Collections.Generic;
using System.Text;

namespace LojaCompreAqui.Business.Models
{
    public class ItemPedido : Entity
    {

        public Guid PedidoId { get; set; }
        public Guid ProdutoId { get; set; }
        public decimal desconto { get; set; }

        public int qtde { get; set; }

        public Pedido Pedido { get; set; }

        public Produto Produto { get; set; }
    }
}
