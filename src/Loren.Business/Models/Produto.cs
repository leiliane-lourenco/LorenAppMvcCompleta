using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loren.Business.Models
{
    public class Produto : Entity
    {
        public Guid FornecedorId { get; set; }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        /* EF Relations */
        public Fornecedor Fornecedor { get; set; }

        public Produto()
        {
            DataCadastro = DateTime.Now;
        }
    }
}