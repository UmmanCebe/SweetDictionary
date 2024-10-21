using Microsoft.AspNetCore.Mvc;
using SweetDictionary.Models.Entities.Categories;
using SweetDictionary.Services.Abstracts;

namespace SweetDictionary.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _categoryService.GetAll();
            return Ok(result);
        }

        [HttpGet("getbyid/{id:int}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var result = _categoryService.GetById(id);
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody] CreateCategoryRequestDto dto)
        {
            var result = _categoryService.Add(dto);
            return Ok(result);
        }

        [HttpDelete("delete/{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var user = _categoryService.Delete(id);
            return Ok(user);
        }

        [HttpPut("update")]
        public IActionResult Update(UpdateCategoryRequestDto dto)
        {
            var result = _categoryService.Update(dto);
            return Ok(result);

        }
    }
}
