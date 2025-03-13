using Event_.Domain;
using Event_.Domains;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class PresencaEventos
{
    [Key]
    public Guid PresencaID { get; set; }  // Se a chave primária for Guid

    public Guid UsuarioID { get; set; }
    [ForeignKey(nameof(UsuarioID))]
    public Usuarios Usuario { get; set; }

    public Guid EventoID { get; set; }  // Mudando de int para Guid
    [ForeignKey(nameof(EventoID))]
    public Eventos Evento { get; set; }
}
