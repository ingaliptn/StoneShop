using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Models;
using ASP_Models.ViewModels;
using ASP_Utility;
using ASP_Utility.BrainTree;
using Braintree;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Rocky_DataAccess.Repository.IRepository;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP_pract.Controllers
{
    [Authorize(Roles = WC.AdminRole)]
    public class OrderController : Controller
    {

        private readonly IOrderHeaderRepository _orderHRepo;
        private readonly IOrderDetailRepository _orderDRepo;
        private readonly IBrainTreeGate _brainTree;

        [BindProperty]
        public OrderVM OrderVM { get; set; }

        public OrderController(
            IOrderHeaderRepository orderHRepo, IOrderDetailRepository orderDRepo, IBrainTreeGate brainTree)
        {
            _brainTree = brainTree;
            _orderDRepo = orderDRepo;
            _orderHRepo = orderHRepo;
        }
        public IActionResult Index(string searchName = null, string searchEmail = null, string searchPhone = null, string Status = null)
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

            if (!string.IsNullOrEmpty(searchName))
            {
                orderListVM.OrderHeaderList = orderListVM.OrderHeaderList.Where(u => u.FullName.ToLower().Contains(searchName.ToLower()));
            }
            if (!string.IsNullOrEmpty(searchEmail))
            {
                orderListVM.OrderHeaderList = orderListVM.OrderHeaderList.Where(u => u.Email.ToLower().Contains(searchEmail.ToLower()));
            }
            if (!string.IsNullOrEmpty(searchPhone))
            {
                orderListVM.OrderHeaderList = orderListVM.OrderHeaderList.Where(u => u.PhoneNumber.ToLower().Contains(searchPhone.ToLower()));
            }
            if (!string.IsNullOrEmpty(Status) && Status != "--Order Status--")
            {
                orderListVM.OrderHeaderList = orderListVM.OrderHeaderList.Where(u => u.OrderStatus.Contains(Status));
            }

            return View(orderListVM);
        }

        public IActionResult Details(int id)
        {
            OrderVM = new OrderVM()
            {
                OrderHeader = _orderHRepo.FirstOrDefault(u => u.Id == id),
                OrderDetail = _orderDRepo.GetAll(o => o.OrderHeaderId == id, includeProperties: "Product")
            };
            return View(OrderVM);
        }

        [HttpPost]
        public IActionResult StartProcessing()
        {
            OrderHeader orderHeader = _orderHRepo.FirstOrDefault(u => u.Id == OrderVM.OrderHeader.Id);
            orderHeader.OrderStatus = WC.StatusInProcess;
            _orderHRepo.Save();
            TempData[WC.Success] = "Order is in process";

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult ShipOrder()
        {
            OrderHeader orderHeader = _orderHRepo.FirstOrDefault(u => u.Id == OrderVM.OrderHeader.Id);
            orderHeader.OrderStatus = WC.StatusShipped;
            orderHeader.ShippingDate = DateTime.Now;
            _orderHRepo.Save();
            TempData[WC.Success] = "Order shipped successfully";

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult CancelOrder()
        {
            OrderHeader orderHeader = _orderHRepo.FirstOrDefault(u => u.Id == OrderVM.OrderHeader.Id);

            var gateWay = _brainTree.GetGateway();
            Transaction transaction = gateWay.Transaction.Find(orderHeader.TransactionId);

            if (transaction.Status == TransactionStatus.AUTHORIZED || transaction.Status == TransactionStatus.SUBMITTED_FOR_SETTLEMENT)
            {
                // no refund
                Result<Transaction> resultvoid = gateWay.Transaction.Void(orderHeader.TransactionId);
            }
            else
            {
                //refund
                Result<Transaction> resultrefund = gateWay.Transaction.Refund(orderHeader.TransactionId);
            }

            orderHeader.OrderStatus = WC.StatusRefunded;
            _orderHRepo.Save();
            TempData[WC.Success] = "Order cancelled successfully";

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult UpdateOrderDetails()
        {
            OrderHeader orderHeaderFromDB = _orderHRepo.FirstOrDefault(u => u.Id == OrderVM.OrderHeader.Id);
            orderHeaderFromDB.FullName = OrderVM.OrderHeader.FullName;
            orderHeaderFromDB.PhoneNumber = OrderVM.OrderHeader.PhoneNumber;
            orderHeaderFromDB.Email = OrderVM.OrderHeader.Email;
            orderHeaderFromDB.Address = OrderVM.OrderHeader.Address;
            orderHeaderFromDB.City = OrderVM.OrderHeader.City;
            orderHeaderFromDB.State = OrderVM.OrderHeader.State;
            orderHeaderFromDB.NP = OrderVM.OrderHeader.NP;

            _orderHRepo.Save();
            TempData[WC.Success] = "Order details updated successfully";

            return RedirectToAction("Details", "Order", new { id = orderHeaderFromDB.Id });
        }
    }
}
