using System.ComponentModel.DataAnnotations;

namespace APICliente.Models
{
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
