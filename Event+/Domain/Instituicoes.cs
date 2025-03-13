using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Event_.Domain
{
    [Table("Instituicao")]
    [Index(nameof(CNPJ),IsUnique =true)]
    public class Instituicoes
    {
        [Key]
        public Guid IdInstituicao { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage ="CNJP e obrigatorio)")]
        [StringLength(14)]
        public string? CNPJ { get; set; }

        [Column(TypeName ="VARCHAR(50)")]
        [Required(ErrorMessage ="O nome da fantasia e orbrigatório")]
        public string? NomeFantasia { get; set; }


        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage = "o endereço e obrigatorio")]
        public string? Endereco { get; set; }
    }
}
