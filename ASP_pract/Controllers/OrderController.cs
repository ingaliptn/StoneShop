using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Models.ViewModels;
using ASP_Utility;
using ASP_Utility.BrainTree;
using Microsoft.AspNetCore.Mvc;
using Rocky_DataAccess.Repository.IRepository;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP_pract.Controllers
{
    public class OrderController : Controller
    {

        private readonly IOrderHeaderRepository _orderHRepo;
        private readonly IOrderDetailRepository _orderDRepo;
        private readonly IBrainTreeGate _brainTree;


        public OrderController(
            IOrderHeaderRepository orderHRepo, IOrderDetailRepository orderDRepo, IBrainTreeGate brainTree)
        {
            _brainTree = brainTree;
            _orderDRepo = orderDRepo;
            _orderHRepo = orderHRepo;
        }
        public IActionResult Index()
        {
            OrderListVM orderListVM = new OrderListVM()
            {
                OrderHeaderList = _orderHRepo.GetAll(),
                StatusList = WC.ListStatus.ToList().Select(i => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
                {
                    Text = i,
                    Value = i
                })
            };
            return View(orderListVM);
        }
    }
}
