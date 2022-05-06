using System;
using System.Collections.Generic;
using System.Linq;
using ASP_DataAccess.Data;
using ASP_DataAccess.Repository.IRepository;
using ASP_Models;
using ASP_Utility;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASP_DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public readonly AppDbContext _db;

        public ProductRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetAllDropdownList(string obj)
        {
            if (obj == WC.CategoryName)
            {
                return _db.Category.Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                });
            }
            if (obj == WC.ApplicationTypeName)
            {
                return _db.ApplicationType.Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                });
            }
            return null;
        }

        public void Update(Product obj)
        {
            _db.Product.Update(obj);
        }
    }
}
