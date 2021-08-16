using System;
using System.Collections.Generic;
using System.Text;

namespace CGShop.Domain.Response
{
    public class ChangeStatusCategoryResult
    {
        public bool Success { get; set; }
        public string Message => Success ? Common.Message.Category.ChangeStatus : Common.Message.Fail;
    }
}
