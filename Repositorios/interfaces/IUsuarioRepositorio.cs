using MicroApi.Models;

namespace MicroApi.Repositorios.interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<List<UserModel>> BuscarTodosUsuarios();
        Task<UserModel> BuscarPorId(int id);
        Task<UserModel> Adicionar(UserModel user);
        Task<UserModel> Atualizar(UserModel user, int id);
        Task<bool> Apagar(int id);
    }
}
