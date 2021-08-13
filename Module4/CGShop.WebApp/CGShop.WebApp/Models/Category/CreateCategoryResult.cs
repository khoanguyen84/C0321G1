using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CGShop.WebApp.Models.Category
{
    public class CreateCategoryResult
    {
        public Category Category { get; set; }
        public bool IsExist { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
