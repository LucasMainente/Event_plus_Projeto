using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Event_.Domain;
using Event_.Domains;

namespace EventoDB.Models
{
    public class ComentarioEvento
    {
        [Key]
        public Guid ComentarioID { get; set; }
        public string Descricao { get; set; }

        [Column(TypeName = "BIT")]
        public bool Exibir { get; set; } = true; // BIT no SQL Server

        public Guid UsuarioID { get; set; }
        public Guid EventoID { get; set; }

        [ForeignKey("UsuarioID")]
        public Usuarios Usuario { get; set; }

        [ForeignKey("EventoID")]
        public Eventos Evento { get; set; }

       
    }
}
