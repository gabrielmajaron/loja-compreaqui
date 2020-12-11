using System;
using System.Collections.Generic;
using System.Text;

namespace LojaCompreAqui.Business.Models
{
    public class Cliente : Entity
    {
        public Guid EnderecoId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Documento { get; set; }
        public Endereco Endereco { get; set; }
        public IEnumerable<Pedido> Pedidos { get; set; }

    }
}
