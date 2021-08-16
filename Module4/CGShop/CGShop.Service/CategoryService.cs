using CGShop.Domain.Response;
using Dapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CGShop.Domain.Request;
using CGShop.Domain;
using Microsoft.Extensions.Configuration;

namespace CGShop.Service
{
    public class CategoryService : BaseService, ICategoryService
    {
        public CategoryService(IConfiguration configuration) : base(configuration)
        {

        }

        public async Task<ChangeStatusCategoryResult> ChangeStatus(ChangeStatusCategory model)
        {
            try
            {
                var foundCategory = await GetById(model.CategoryId);

                if (foundCategory != null)
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@categoryId", model.CategoryId);
                    parameters.Add("@status", model.Status);

                    var categoryId = await SqlMapper.QueryFirstOrDefaultAsync<int>(
                                            cnn: connection,
                                            sql: "sp_ChangeStatusCategory",
                                            param: parameters,
                                            commandType: CommandType.StoredProcedure
                                        );
                    return new ChangeStatusCategoryResult()
                    {
                        Success = categoryId > 0
                    };
                }
                return new ChangeStatusCategoryResult()
                {
                    Success = false
                };
            }
            catch (Exception)
            {
                return new ChangeStatusCategoryResult()
                {
                    Success = false
                };
            }
        }

        public async Task<CreateCategoryResult> Create(CreateCategory create)
        {
            try
            {
                var foundCategory = await GetByName(create.CategoryName);

                if(foundCategory == null)
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@categoryName", create.CategoryName);
                    parameters.Add("@status", create.Status);

                    var category = await SqlMapper.QueryFirstOrDefaultAsync<Category>(
                                            cnn: connection,
                                            sql: "sp_CreateCategory",
                                            param: parameters,
                                            commandType: CommandType.StoredProcedure
                                        );
                    return new CreateCategoryResult()
                    {
                        IsExist = false,
                        Category = category
                    };
                }
                return new CreateCategoryResult()
                {
                    Category = foundCategory,
                    IsExist = true
                };
            }
            catch (Exception ex)
            {
                return new CreateCategoryResult()
                {
                    Category = new Category()
                };
            }
        }

        public async Task<DeleteCategoryResult> Delete(int categoryId)
        {
            try
            {
                var foundCategory = await GetById(categoryId);

                if (foundCategory != null)
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@categoryId", categoryId);

                    var category = await SqlMapper.QueryFirstOrDefaultAsync<Category>(
                                            cnn: connection,
                                            sql: "sp_RemoveCategory",
                                            param: parameters,
                                            commandType: CommandType.StoredProcedure
                                        );
                    return new DeleteCategoryResult()
                    {
                        Success = true,
                        NotFound = false
                    };
                }
                return new DeleteCategoryResult()
                {
                    Success = false,
                    NotFound = true
                };
            }
            catch (Exception ex)
            {
                return new DeleteCategoryResult()
                {
                    Success = false,
                    NotFound = false
                };
            }
        }

        public async Task<IEnumerable<Category>> Get()
        {
            var categories = await SqlMapper.QueryAsync<Category>(
                                cnn: connection, 
                                sql: "sp_GetCategories", 
                                commandType: CommandType.StoredProcedure);
            return categories;
        }

        public async Task<Category> GetById(int categoryId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@categoryId", categoryId);
            var category = await SqlMapper.QueryFirstOrDefaultAsync<Category>(
                                cnn: connection,
                                sql: "sp_GetCategory",
                                param: parameters,
                                commandType: CommandType.StoredProcedure);
            return category;
        }

        public async Task<Category> GetByName(string catName, int categoryId = 0)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@categoryName", catName);
            parameters.Add("@categoryId", categoryId);
            var category = await SqlMapper.QueryFirstOrDefaultAsync<Category>(
                                cnn: connection,
                                sql: "sp_GetCategoryByName",
                                param: parameters,
                                commandType: CommandType.StoredProcedure);
            return category;
        }

        public async Task<UpdateCategoryResult> Update(UpdateCategory update)
        {
            try
            {
                var foundCategory = await GetByName(update.CategoryName, update.CategoryId);

                if (foundCategory == null)
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@categoryId", update.CategoryId);
                    parameters.Add("@categoryName", update.CategoryName);
                    parameters.Add("@status", update.Status);

                    var category = await SqlMapper.QueryFirstOrDefaultAsync<Category>(
                                            cnn: connection,
                                            sql: "sp_ModifyCategory",
                                            param: parameters,
                                            commandType: CommandType.StoredProcedure
                                        );
                    return new UpdateCategoryResult()
                    {
                        IsExist = false,
                        Category = category
                    };
                }
                return new UpdateCategoryResult()
                {
                    Category = foundCategory,
                    IsExist = true
                };
            }
            catch (Exception ex)
            {
                return new UpdateCategoryResult()
                {
                    Category = new Category()
                };
            }
        }
    }
}
