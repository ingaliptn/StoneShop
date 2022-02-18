using System;
namespace ASP_Models.ViewModels
{
    public class DetailsVM
    {
        public Product Product { get; set; }

        public Boolean ExistInCart { get; set; }


        public DetailsVM()
        {
            Product = new();
        }
    }
}
