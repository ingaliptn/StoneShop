using System;
using System.Linq;
using ASP_DataAccess.Data;
using ASP_DataAccess.Repository.IRepository;
using ASP_Models;

namespace ASP_DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public readonly AppDbContext _db;

        public CategoryRepository(AppDbContext db):base(db)
        {
            _db = db;
        }

        public void Update(Category obj)
        {
            var objFromDb = _db.Category.FirstOrDefault(u => u.Id == obj.Id);
            if(objFromDb != null)
            {
                objFromDb.Name = obj.Name;
                objFromDb.DisplayOrder = obj.DisplayOrder;

            }
        }
    }
}
