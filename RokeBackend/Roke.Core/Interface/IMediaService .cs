
using Roke.Core.Model;
using RokeBackend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RokeBackend.core.Interface
{
    public interface IMediaService
    {
        public Task<Media> CreateMedia(Media media);
        public IEnumerable<Media> getAllMedias();
        public Task<Media> getMediaByIdAsync(Guid id);
        public Task<Media> UpdateMedia(Media media);
        public Task<int> RemoveMedia(Guid id);

    }
}
