using System;
using System.Linq;
using ASP_DataAccess.Data;
using ASP_DataAccess.Repository.IRepository;
using ASP_Models;

namespace ASP_DataAccess.Repository
{
    public class ApplicationTypeRepository : Repository<ApplicationType>, IApplicationTypeRepository
    {
        public readonly AppDbContext _db;

        public ApplicationTypeRepository(AppDbContext db):base(db)
        {
            _db = db;
        }

        public void Update(ApplicationType obj)
        {
            var objFromDb = _db.ApplicationType.FirstOrDefault(u => u.Id == obj.Id);
            if(objFromDb != null)
            {
                objFromDb.Name = obj.Name;
            }
        }

    }
}
