using Microsoft.AspNetCore.Mvc;

namespace FormulaApp.Api.Controllers;

public class FansController : BaseController
{
    [HttpGet(Name = "GetFans")]
    public IActionResult GetAll() => Ok("Fans");
}