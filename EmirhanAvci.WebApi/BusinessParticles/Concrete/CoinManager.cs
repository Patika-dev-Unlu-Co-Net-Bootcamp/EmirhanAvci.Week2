using EmirhanAvci.WebApi.BusinessParticles.Abstract;
using EmirhanAvci.WebApi.DataParticles.Abstract;
using EmirhanAvci.WebApi.FixedDataOperations.DataListOperations;
using EmirhanAvci.WebApi.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmirhanAvci.WebApi.BusinessParticles.Concrete
{
    public class CoinManager : ICoinService
    {
        ICoinParticleGeneratorService _coinParticleGeneratorService;
        public CoinManager(ICoinParticleGeneratorService coinParticleGeneratorService)
        {
            _coinParticleGeneratorService = coinParticleGeneratorService;
        }
        
        public List<Coin> GetAll()
        {
            return _coinParticleGeneratorService.GetAll();
        }
    }
}
