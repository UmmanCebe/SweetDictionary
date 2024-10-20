using Microsoft.AspNetCore.Mvc;
using SweetDictionary.Models.Entities;
using SweetDictionary.Models.Entities.Users;
using SweetDictionary.Services.Abstracts;

namespace SweetDictionary.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _userService.GetAll();
            return Ok(result);
        }

        [HttpGet("getbyid/{id:long}")]
        public IActionResult GetById(long id)
        {
            var result = _userService.GetById(id);
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody] CreateUserRequestDto dto)
        {
            var result = _userService.Add(dto);
            return Ok(result);
        }

        [HttpDelete("delete/{id:long}")]
        public IActionResult Delete([FromRoute] long id)
        {
            var user = _userService.Delete(id);
            return Ok(user);
        }

        [HttpPost("update")]
        public IActionResult Update(UpdateUserRequestDto dto)
        {
            var result = _userService.Update(dto);
            return Ok(result);

        }
    }
}
