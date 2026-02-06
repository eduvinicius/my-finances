using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyFinances.Api.DTOs;
using MyFinances.App.Services.Interfaces;

namespace MyFinances.Api.Controllers
{
    [ApiController]
    [Route("api/categories")]
    public class CategoriesController(ICategoryService categoryService)
        : ControllerBase
    {
        private readonly ICategoryService _categoryService = categoryService;

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAllCategories()
        {
            var categories = await _categoryService.GetAllAsync();
            return Ok(categories);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateCategory(CategoryDto dto)
        {
            var category = await _categoryService.CreateAsync(dto);
            return Ok(category);
        }

    }

}
