using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.NET_Meeting_11.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Категория")]
        public string CategoryName { get; set; }
        public virtual ICollection<Good> Goods { get; set; }
        public Category()
        {
            Goods = new List<Good>();
        }
    }
}