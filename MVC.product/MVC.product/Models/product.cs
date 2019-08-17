using System.ComponentModel.DataAnnotations;

namespace MVC.product.Models
{
    public class product
    {
        [Key]
        public int productID { get; set; }

        [Required]
        [Display(Description ="Product Name")]
        public string Name { get; set; }

        public string Description { get; set; }

    }
}