using ASP_DataAccess.Data;
using ASP_DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocky_DataAccess.Repository.IRepository
{
    public interface IOrderHeaderRepository : Repository<OrderHeader>
    {
        void Update(OrderHeader obj);


    }
}
