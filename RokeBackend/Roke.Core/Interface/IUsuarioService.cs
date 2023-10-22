
using Roke.Core.Model;
using RokeBackend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RokeBackend.core.Interface
{
    public interface IUsuarioService
    {
        public IEnumerable<user> GetAllUsuario();
        public IEnumerable<user> getAllTech();
        public Task<user> GetUsuarioById(Guid id);
        public Task<user> SaveUsuario(user usuario);
        public Task<user> UpdateUsuario(user user);
        public Task<int> DeleteUsuario(Guid idUsuario);
        IEnumerable<user> GetAllUsuarios();
    }
}
