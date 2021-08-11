using System;
using System.Collections.Generic;
using System.Text;

namespace CGShop.Domain.Request
{
    public class CreateCategory
    {
        public string CategoryName { get; set; }
        public bool Status { get; set; }
    }
}
