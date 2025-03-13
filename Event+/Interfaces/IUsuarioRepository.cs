
using Event_.Domains;

namespace Event_.Interfaces
{
    public interface IUsuarioRepository
    {
        public interface IUsuarioRepository
        {
            void Cadastrar(Usuarios novoUsuarios);

            List<Usuarios> Listar();
            
            Usuarios BuscarPorId(Guid id);

            void Deletar(Guid id);

        }

    }
}


