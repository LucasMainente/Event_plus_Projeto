using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Event_.Domain
{
    [Table("TipoEvento")]
    public class TiposEventos
    {
        [Key]
        public Guid TipoEventoID { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O título do tipo de evento é obrigatório")]
        public string? TituloTipoEvento { get; set; }
    }
}
