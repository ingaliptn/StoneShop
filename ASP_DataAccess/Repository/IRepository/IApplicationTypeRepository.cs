using System;
using ASP_Models;

namespace ASP_DataAccess.Repository.IRepository
{
    public interface IApplicationTypeRepository : Repository<ASP_Models.ApplicationType>
    {
        void Update(ApplicationType obj);
    }
}
