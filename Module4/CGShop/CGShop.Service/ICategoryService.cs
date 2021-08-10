using CGShop.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CGShop.Service
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> Get();
    }
}
