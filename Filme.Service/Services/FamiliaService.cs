using Filme.Domain.Familia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filme.Service.Services
{
    public class FamiliaService : IFamiliaService
    {
        private readonly IFamiliaRepository _FamiliaRepository;

        public FamiliaService(IFamiliaRepository FamiliaRepository)
        {
            _FamiliaRepository = FamiliaRepository;
        }
        public async Task Delete(Guid id)
        {
            await _FamiliaRepository.Delete<Familia>(id);
        }

        public async Task<Familia> Get(Guid id)
        {
            return await _FamiliaRepository.Get<Familia>(id);
        }

        public async Task Post(Familia familia)
        {
            await _FamiliaRepository.Post(familia);
        }

        public async Task Put(Familia familia)
        {
            await _FamiliaRepository.Put(familia);
        }
    }
}
