using Microsoft.AspNetCore.Mvc;
using SweetDictionary.Models.Entities.Posts;
using SweetDictionary.Services.Abstracts;


namespace SweetDictionary.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PostsController(IPostService _postService) : ControllerBase
{
    //private readonly IPostService _postService;   // yukarıdaki yapı primary constructer yapısı bu şekilde de DI yapabiliriz.

    //public PostsController(IPostService postService)
    //{
    //    _postService = postService;
    //}

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var result = _postService.GetAll();
        return Ok(result);
    }

    [HttpPost("add")]
    public IActionResult Add([FromBody] CreatePostRequestDto dto)
    {
        var result = _postService.Add(dto);
        return Ok(result);
    }

    [HttpGet("getbyid/{id}")]
    public IActionResult GetById([FromRoute] Guid id)
    {
        var result = _postService.GetById(id);
        return Ok(result);
    }
}