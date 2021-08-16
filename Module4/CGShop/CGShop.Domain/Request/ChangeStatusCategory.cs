using System;
using System.Collections.Generic;
using System.Text;

namespace CGShop.Domain.Request
{
    public class ChangeStatusCategory
    {
        public int CategoryId { get; set; }
        public bool Status { get; set; }
    }
}
