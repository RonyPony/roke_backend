
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
    public class MediaService : IMediaService
    {
        private readonly IMediaRepository _repo;


     


        public MediaService(IMediaRepository repo)
        {
            _repo = repo;
        }

        public Task<Media> CreateMedia(Media data)
        {
            return _repo.CreateMedia(data);
        }

        public IEnumerable<Media> getAllMedias()
        {
           return _repo.getAllMedias();
        }

        public Task<int> RemoveMedia(Guid id)
        {
            return _repo.RemoveMedia(id);

        }

        public Task<Media> getMediaByIdAsync(Guid id)
        {
            return _repo.getMediaByIdAsync(id);
        }
        

          public Task<Media> UpdateMedia(Media media)
        {
            return _repo.UpdateMedia(media);
        }

 
    }
}
