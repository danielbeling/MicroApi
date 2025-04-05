using MicroApi.Data;
using MicroApi.Models;
using MicroApi.Repositorios.interfaces;
using Microsoft.EntityFrameworkCore;

namespace MicroApi.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly SistemaDeTarefasContext _dbcontext;
        public UsuarioRepositorio(SistemaDeTarefasContext sistemaDeTarefasContext)
        {
            _dbcontext = sistemaDeTarefasContext;
        }
        public async Task<UserModel> BuscarPorId(int id)
        {
            return await _dbcontext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<UserModel>> BuscarTodosUsuarios()
        {
            return await _dbcontext.Usuarios.ToListAsync();
        }
        public async Task<UserModel> Adicionar(UserModel user)
        {
          await _dbcontext.Usuarios.AddAsync(user);
          await  _dbcontext.SaveChangesAsync();
            return user;
        }

        public async Task<UserModel> Atualizar(UserModel user, int id)
        {
            UserModel usuarioPorId = await BuscarPorId(id);

            if (usuarioPorId == null)
            {
                throw new Exception($"Usuário para o ID: {id} não foi encontrado no banco de dados.");
            }
            usuarioPorId.Name = user.Name;
            usuarioPorId.Email = user.Email;

            _dbcontext.Usuarios.Update(usuarioPorId);
            await _dbcontext.SaveChangesAsync();

            return usuarioPorId;
   
        }

        public async Task<bool> Apagar(int id)
        {
            UserModel usuarioPorId = await BuscarPorId(id);
            if (usuarioPorId == null)
            {
                throw new Exception($"Usuário para o ID: {id} não foi encontrado no banco de dados.");
            }

            _dbcontext.Usuarios.Remove(usuarioPorId);
            await _dbcontext.SaveChangesAsync();
            return true;
        }
    }
}
