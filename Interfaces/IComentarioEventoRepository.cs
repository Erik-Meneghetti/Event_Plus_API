using EventPlusAPI.Domains;

namespace EventPlusAPI.Interfaces
{
    public interface IComentarioEventoRepository
    {
        void Cadastrar(ComentarioEvento comentarioEvento);

        void Deletar(Guid id);

        List<ComentarioEvento> Listar();

        ComentarioEvento BuscarPorIdUsuario(Guid UsuarioID, Guid EventosID);

    }
}
