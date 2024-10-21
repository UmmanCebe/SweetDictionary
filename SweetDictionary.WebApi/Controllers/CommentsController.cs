using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SweetDictionary.Models.Entities.Comments;
using SweetDictionary.Models.Entities.Users;
using SweetDictionary.Services.Abstracts;
using SweetDictionary.Services.Concretes;

namespace SweetDictionary.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentsController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _commentService.GetAll();
            return Ok(result);
        }

        [HttpGet("getbyid/{id:guid}")]
        public IActionResult GetById(Guid id)
        {
            var result = _commentService.GetById(id);
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody] CreateCommentRequestDto dto)
        {
            var result = _commentService.Add(dto);
            return Ok(result);
        }

        [HttpDelete("delete/{id:guid}")]
        public IActionResult Delete([FromRoute] Guid id)
        {
            var user = _commentService.Delete(id);
            return Ok(user);
        }

        [HttpPut("update")]
        public IActionResult Update(UpdateCommentRequestDto dto)
        {
            var result = _commentService.Update(dto);
            return Ok(result);

        }
    }
}
