
using RokeBackend.core.Interface;
using RokeBackend.Model;
using RokeBackend.data.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RokeBackend.core.Contracts;
using Roke.Core.Model;

namespace RokeBackend.data.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repo;

        public UsuarioService(IUsuarioRepository repo)
        {
            _repo = repo;
        }

        public Task<int> DeleteUsuario(Guid idUsuario)
        {
            return _repo.RemoveUsuario(idUsuario);

        }

        public IEnumerable<user> GetAllUsuario()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<user> GetAllUsuarios()
        {
            return _repo.getAllUsuarios();
        }

        public Task<user> GetUsuarioById(Guid id)
        {
            return _repo.getUsuarioByIdAsync(id);
        }



        public Task<user> SaveUsuario(user user)
        {
            return _repo.CreateUsuario(user);
        }

        public async Task<user> UpdateTicket(user user)
        {
            return await _repo.UpdateUsuario(user);
        }

        public Task<user> UpdateUsuario(user usuario)
        {
            throw new NotImplementedException();
        }
    }
}
