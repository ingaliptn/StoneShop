using System;
using System.Collections;
using System.Collections.Generic;
using ASP_Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASP_DataAccess.Repository.IRepository
{
    public interface IProductRepository : Repository<Product>
    {
        void Update(Product obj);

        IEnumerable<SelectListItem> GetAllDropdownList(string obj);
    }
}
