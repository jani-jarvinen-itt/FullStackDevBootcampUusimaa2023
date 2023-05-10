using Microsoft.AspNetCore.Mvc;

namespace SimpleHttpApiDemo.Controllers;

[ApiController]
[Route("[controller]")]
public class MySimpleApiController : ControllerBase
{
    public string SayHello()
    {
        return "Hello World from a ASP.NET C# web API application.";
    }
}
