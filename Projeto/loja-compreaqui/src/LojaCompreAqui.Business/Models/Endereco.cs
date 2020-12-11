using System;
using System.ComponentModel.DataAnnotations;

namespace LojaCompreAqui.Business.Models
{  
    public class Endereco : Entity
    {
        public string Logradouro { get; set; }
        
        public string Numero { get; set; }
                       
        public string Complemento { get; set; }
      
        public string Cep { get; set; }
        
        public string Bairro { get; set; }
    
        public string Cidade { get; set; }
        public string Estado { get; set; }

        /* Relacionamentos E.F. */
        // um endereço pertence a 1 fornec. apenas
        public Fornecedor Fornecedor { get; set; }
        public Cliente Cliente { get; set; }
    }
}
