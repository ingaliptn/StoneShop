using System;
using System.Linq;
using ASP_DataAccess.Data;
using ASP_DataAccess.Repository.IRepository;
using ASP_Models;

namespace ASP_DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        public readonly AppDbContext _db;

        public ApplicationUserRepository(AppDbContext db):base(db)
        {
            _db = db;
        }
    }
}
