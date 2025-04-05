using MicroApi.Data;
using MicroApi.Models;
using MicroApi.Repositorios.interfaces;
using Microsoft.EntityFrameworkCore;

namespace MicroApi.Repositorios
{
    public class TarefaRepositorio : ITarefaRepositorio
    {
        private readonly SistemaDeTarefasContext _dbcontext;
        public TarefaRepositorio(SistemaDeTarefasContext sistemaDeTarefasContext)
        {
            _dbcontext = sistemaDeTarefasContext;
        }
        public async Task<TarefaModel> BuscarPorId(int id)
        {
            return await _dbcontext.Tarefas
                .Include(x => x.Usuario)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<TarefaModel>> BuscarTodosTarefas()
        {
            return await _dbcontext.Tarefas
                .Include (x => x.Usuario)
                .ToListAsync();
        }
        public async Task<TarefaModel> Adicionar(TarefaModel tarefa)
        {
          await _dbcontext.Tarefas.AddAsync(tarefa);
          await  _dbcontext.SaveChangesAsync();
            return tarefa;
        }

        public async Task<TarefaModel> Atualizar(TarefaModel tarefa, int id)
        {
            TarefaModel tarefaPorId = await BuscarPorId(id);

            if (tarefaPorId == null)
            {
                throw new Exception($"Tarefa para o ID: {id} não foi encontrado no banco de dados.");
            }
            tarefaPorId.Name = tarefa.Name;
            tarefaPorId.Description = tarefa.Description;
            tarefaPorId.Status = tarefa.Status;
            tarefaPorId.UserId = tarefa.UserId;

            _dbcontext.Tarefas.Update(tarefaPorId);
            await _dbcontext.SaveChangesAsync();

            return tarefaPorId;
   
        }

        public async Task<bool> Apagar(int id)
        {
            TarefaModel tarefaPorId = await BuscarPorId(id);
            if (tarefaPorId == null)
            {
                throw new Exception($"Tarefa para o ID: {id} não foi encontrado no banco de dados.");
            }

            _dbcontext.Tarefas.Remove(tarefaPorId);
            await _dbcontext.SaveChangesAsync();
            return true;
        }
    }
}
