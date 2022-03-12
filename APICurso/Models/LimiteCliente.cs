using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICurso.Models
{
    [Table("LimiteClientes")]
    public class LimiteCliente
    {
        [Key]
        public int LimiteId { get; set; }
        [Required]
        [MaxLength(80)]
        public string Nome { get; set; }
        [Required]
        public float LimiteCredito { get; set; }
    }
}
