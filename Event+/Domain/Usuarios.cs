using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EventoDB.Models;
using Microsoft.EntityFrameworkCore;

namespace Event_.Domains
{
    [Table("Usuario")]
    [Index(nameof(Email), IsUnique = true)]


    public class Usuarios
    {
        [Key]
        public Guid IdUsuario { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O nome é obrigatório!")]
        public string? Nome { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O email é obrigatório!")]
        public string? Email { get; set; }

        [Column(TypeName = "VARCHAR(60)")]
        [Required(ErrorMessage = "A senha é obrigatória!")]
        [StringLength(60, MinimumLength = 6, ErrorMessage = "A senha no minimo deve ter 6 caracteres")]
        public string? Senha
        {
            get; set;
        }

        
    
    }
}