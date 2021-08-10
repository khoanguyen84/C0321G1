using System;
using System.Collections.Generic;
using System.Text;

namespace CGShop.Domain.Response
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool Status { get; set; }
    }
}
