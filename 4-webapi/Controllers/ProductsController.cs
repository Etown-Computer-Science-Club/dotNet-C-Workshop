using Microsoft.AspNetCore.Mvc;

namespace Workshop.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private static readonly List<string> Products = new() { "Keyboard", "Mouse", "Monitor" };

    [HttpGet]
    public IActionResult GetAll() => Ok(Products);

    [HttpGet("{id:int}")]
    public IActionResult Get(int id)
    {
        if (id < 0 || id >= Products.Count) return NotFound();
        return Ok(Products[id]);
    }

    [HttpPost]
    public IActionResult Add([FromBody] string name)
    {
        if (string.IsNullOrWhiteSpace(name)) return BadRequest("Name required");
        Products.Add(name.Trim());
        return CreatedAtAction(nameof(Get), new { id = Products.Count - 1 }, name);
    }

    [HttpDelete("{id:int}")]
    public IActionResult Remove(int id)
    {
        if (id < 0 || id >= Products.Count) return NotFound();
        var removed = Products[id];
        Products.RemoveAt(id);
        return Ok(removed);
    }
}
