using CGShop.Domain.Request;
using CGShop.Domain.Response;
using CGShop.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CGShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        /// <summary>
        /// Get all category
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<Category>> Get()
        {
            return await categoryService.Get();
        }

        /// <summary>
        /// Get category by categoryId
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Category</returns>
        [HttpGet]
        [Route("{id:int}")]
        public async Task<Category> GetById(int id)
        {
            return await categoryService.GetById(id);
        }

        /// <summary>
        /// Create new category
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<CreateCategoryResult> Create(CreateCategory model)
        {
            return await categoryService.Create(model);
        }

        /// <summary>
        /// Update category
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<UpdateCategoryResult> Update(UpdateCategory model)
        {
            return await categoryService.Update(model);
        }

        /// <summary>
        /// Soft delete category by category id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<DeleteCategoryResult> Delete(int id)
        {
            return await categoryService.Delete(id);
        }
    }
}
