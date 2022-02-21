using ASP_DataAccess.Data;
using ASP_DataAccess.Repository.IRepository;
using ASP_Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocky_DataAccess.Repository.IRepository
{
    public interface IOrderDetailRepository : Repository<OrderDetail>
    {
        void Update(OrderDetail obj);


    }
}
