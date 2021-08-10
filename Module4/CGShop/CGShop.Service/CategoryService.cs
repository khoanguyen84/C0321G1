using CGShop.Domain.Response;
using Dapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CGShop.Service
{
    public class CategoryService : BaseService, ICategoryService
    {
        public async Task<IEnumerable<Category>> Get()
        {
            var categories = await SqlMapper.QueryAsync<Category>(cnn: connection, sql: "sp_GetCategories", commandType: CommandType.StoredProcedure);
            return categories;
        }
    }
}
