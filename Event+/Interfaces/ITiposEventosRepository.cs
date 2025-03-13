using Event_.Domain;

namespace Event_.Interfaces
{
    public interface ITiposEventosRepository
    {
        void Cadastrar(TiposEventos novoTipoEventos);

        void Atualizar(TiposEventos tiposEventos);

        void Deletar(TiposEventos tiposEventos);
    }
}
