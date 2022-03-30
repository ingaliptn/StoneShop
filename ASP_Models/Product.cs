using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_Models
{
    public class Product
    {
        public Product()
        {
            TempSqm = 1;
        }


        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string ShortDesc { get; set; }
        public string Description { get; set; }
        [Range(1, int.MaxValue)]
        public double Price { get; set; }
        public string Image { get; set; }
        [Display(Name = "Category Type")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        [Display(Name = "App Type")]
        public int ApplicationTypeId { get; set; }
        [ForeignKey("ApplicationTypeId")]
        public virtual ApplicationType ApplicationType { get; set; }


        [NotMapped]
        [Range(1, 10000, ErrorMessage = "SqM must be greater then 0!")]
        public int TempSqm { get; set; }

    }
}
