
using Roke.Core.Model;
using RokeBackend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RokeBackend.core.Interface
{
    public interface IFirmaService
    {
        public Task<Firma> CreateFirma(Firma data);
        public IEnumerable<Firma> getAllFirma();
        public Task<Firma> getFirmaByIdAsync(Guid id);
        public Task<Firma> UpdateFirma(Firma data);
        public Task<int> RemoveFirma(Guid id);

    }
}
