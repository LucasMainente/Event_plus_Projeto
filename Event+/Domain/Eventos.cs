using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EventoDB.Models;

namespace Event_.Domain
{
    [Table("Evento")]
    public class Eventos
    {
        [Key]
        public Guid IdEvento { get; set; }

        // Chave estrangeira para TipoEvento
        public Guid IdTipoEvento { get; set; }
        [ForeignKey(nameof(IdTipoEvento))]
        public TiposEventos? TipoEvento { get; set; }

        // Chave estrangeira para Instituicao
        [ForeignKey("IdInstituicao")]
        public Guid IdInstituicao { get; set; }
        
        public Instituicoes? Instituicao { get; set; }
        [Column(TypeName ="DATE")]
        [Required(ErrorMessage = "A data do evento e obrigatoria")]
        public DateTime? DataEvento { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O nome do evento é obrigatório")]
        public string? NomeEvento { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "A descrição do evento é obrigatória")]
        public string? Descricao { get; set; }

        public PresencaEventos? PresencaEventos { get; set; }
        public Guid IdTipoUsuario { get; set; }

        [ForeignKey("IdTipoUsuario")]

        public TiposUsuarios? TipoUsuarios { get; set; }
    }

}
