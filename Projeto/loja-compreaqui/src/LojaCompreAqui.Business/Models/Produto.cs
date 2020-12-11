using System;

namespace LojaCompreAqui.Business.Models
{
    public class Produto : Entity
    {
        // OS IDS ABAIXO SERÃO A FOREIGN KEY, MAPEADOS NO BANCO DE DADOS PELA CLASSE PRODUTOMAPPING
        public Guid FornecedorId { get; set; }
        public Guid CategoriaId { get; set; }
        public string Nome { get; set; }        
        public string Descricao { get; set; }        
        public string Imagem { get; set; }        
        public decimal Valor { get; set; }        
        public DateTime DataCadastro { get; set; }       
        public bool Ativo { get; set; }

        /* Relacionamentos E.F. */
        // Informa ao E.F. que o produto possui so um fornec.
        public Fornecedor Fornecedor { get; set; }
        // /\ conhecido como propriedade de navegação para o E.F.

        public Categoria Categoria { get; set; }
    }
}
