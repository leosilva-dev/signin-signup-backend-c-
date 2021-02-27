using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class User
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(100, ErrorMessage = "Tamanho máximo atingido")]
        [MinLength(3, ErrorMessage = "Tamanho mínimo necessário (3)")]
        public string Name { get; set; }

        [MaxLength(80, ErrorMessage = "Tamanho máximo atingido")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(200, ErrorMessage = "Tamanho máximo atingido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MinLength(6, ErrorMessage = "Tamanho mínimo necessário (6)")]
        public string Password { get; set; }
    }
}