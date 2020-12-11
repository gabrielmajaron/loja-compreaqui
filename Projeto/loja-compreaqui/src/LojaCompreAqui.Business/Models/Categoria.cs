using System;
using System.Collections.Generic;
using System.Text;

namespace LojaCompreAqui.Business.Models
{
    public class Categoria : Entity
    {
        public string Nome { get; set; }

        /* Relacionamento do E.F. */
        // Informa ao E.F. que a categoria tem uma relação de 
        // 1 para muitos com o produto
        public IEnumerable<Produto> Produtos { get; set; }
    }
}
