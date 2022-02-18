using ASP_Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_DataAccess.Repository.IRepository
{
    public interface IInquiryDetailRepository : Repository<InquiryDetail>
    {
        void Update(InquiryDetail obj);


    }
}
