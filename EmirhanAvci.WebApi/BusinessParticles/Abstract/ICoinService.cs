using EmirhanAvci.WebApi.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmirhanAvci.WebApi.BusinessParticles.Abstract
{
    #region NamingDescription
    /*
        Main folder name is BusinessParticles.Normally we can name it  
     */
    #endregion

    public interface ICoinService
    {
        List<Coin> GetAll();
    }
}
