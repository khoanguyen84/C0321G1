using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CGShop.WebApp.Models.Category
{
    public class UpdateCategory
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool Status { get; set; }
    }
}
