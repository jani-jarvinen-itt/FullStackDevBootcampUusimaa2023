using Microsoft.AspNetCore.Mvc;
using NorthwindHttpApi.Databases;

namespace NorthwindHttpApi.Controllers;

[ApiController]
[Route("api/customers")]
public class CustomersApiController : ControllerBase
{
    public List<string> GetAllCustomers()
    {
        NorthwindDataAccess access = new();
        List<string> companyNames = access.GetAllCustomers();
        return companyNames;
    }
}
