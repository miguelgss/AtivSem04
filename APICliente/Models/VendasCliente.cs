using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICliente.Models
{
    [Table("VendasClientes")]
    public class VendasCliente
    {
        [Key]
        public int VendaId { get; set; }

        public int LimiteId { get; set; }
        public DateTime DataVenda { get; set; }
        public float Venda { get; set; }
    }
}
