using System;
using ASP_Models;

namespace ASP_DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : Repository<Category>
    {
        void Update(Category obj);
    }
}
