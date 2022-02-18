using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASP_Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }

        public IEnumerable<SelectListItem> CategoryListItem { get; set; }
        public IEnumerable<SelectListItem> AppListListItem { get; set; }

        public ProductVM()
        {
        }
    }
} 
