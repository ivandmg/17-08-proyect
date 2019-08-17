using System.Data.Entity;

namespace MVC.product.Models
{
    public class AtaContext:DbContext
    {
        public AtaContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVC.product.Models.product> products { get; set; }
    }
}