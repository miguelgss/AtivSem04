using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICliente.Models
{
    public class VendasCliente
    {
        public int VendaId { get; set; }

        public int LimiteId { get; set; }
        public DateTime DataVenda { get; set; }
        public float Venda { get; set; }
    }
}
