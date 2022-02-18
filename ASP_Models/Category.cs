 using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1,int.MaxValue,ErrorMessage = "Wrong number")]
        public int DisplayOrder { get; set; }

        public Category()
        {
        }
    }
}
