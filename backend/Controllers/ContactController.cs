using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("[controller]")]
public class ContactController : ControllerBase
{
    [HttpGet(Name = "contacts")]
    public IEnumerable<Contact> Get()
    {
        return [];
    }
}
