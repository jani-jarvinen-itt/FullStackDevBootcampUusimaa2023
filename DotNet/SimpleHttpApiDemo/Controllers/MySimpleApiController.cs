using Microsoft.AspNetCore.Mvc;

namespace SimpleHttpApiDemo.Controllers;

[ApiController]
[Route("[controller]")]
public class MySimpleApiController : ControllerBase
{
    [Route("hello")]
    public string SayHello()
    {
        return "Hello World from a ASP.NET C# web API application.";
    }

    [Route("time")]
    public DateTime CurrentTime()
    {
        return DateTime.Now;
    }

    [Route("numbers")]
    public List<int> ReturnNumbers()
    {
        return new() { 9, 8, 7, 6, 5, 1, 2, 3, 4 };
    }
}
