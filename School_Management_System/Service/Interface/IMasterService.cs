using School_Management_System.Data.MasterData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Management_System.Service.Interface
{
    public interface IMasterService
    {
        #region
        Task<int> SaveCountry(Country country);
        Task<IEnumerable<Country>> GetCountry();
        #endregion

        #region
        Task<int> SaveDivision(Division division);
        Task<IEnumerable<Division>> GetDivision();
        #endregion

        #region
        Task<int> SaveDistrict(District district);
        Task<IEnumerable<District>> GetDistrict();
        #endregion

    }
}
