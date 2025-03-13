using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Event_.Domain;

namespace Event_.Interfaces
{
    public interface IEventoRepository
    {
      void Cadastrar(Eventos novoEvento);

        void Atualizar(Eventos idEvento);

        void Deletar(Eventos idEvento); 

        void BuscarPorid(Eventos idEvento);
    }
}
