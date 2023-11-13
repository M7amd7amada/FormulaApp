using Microsoft.AspNetCore.Mvc;

namespace FormulaApp.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class BaseController : ControllerBase
{
    public BaseController() { }
}