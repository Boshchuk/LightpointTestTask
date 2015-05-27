using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LightpointTestTask.Models
{
    public class Store
    {
        [Key]
        [Display(Name = "Store Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StoreId { get; set; }

        [Display(Name = "Store Name")]
        public string StoreName { get; set; }

        public string Address { get; set; }

        public string WorkHours { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}