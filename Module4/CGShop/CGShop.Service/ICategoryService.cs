using CGShop.Domain.Request;
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
        Task<Category> GetById(int categoryId);
        Task<CreateCategoryResult> Create(CreateCategory create);
        Task<Category> GetByName(string catName, int categoryId);
        Task<UpdateCategoryResult> Update(UpdateCategory update);
        Task<DeleteCategoryResult> Delete(int categoryId);
    }
}
