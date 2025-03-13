using System.ComponentModel.DataAnnotations;
using Event_.Domains;

namespace EventoDB.Models
{
    public class TiposUsuarios
    {
        [Key]
        public Guid TipoUsuarioID { get; set; }
        public string TituloTipoUsuario { get; set; }
    }
}
