using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace LightpointTestTask.Models
{
    public class Store
    {
        [Display(Name = "Store Id")]
        public int StoreId { get; set; }

        [Display(Name = "Store Name")]
        public string StoreName { get; set; }

        public string Address { get; set; }

        public string WorkHours { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}