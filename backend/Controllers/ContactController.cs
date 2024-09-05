using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("contacts")]
public class ContactController : ControllerBase
{
    private ContactService contactService = new ContactService();

    [HttpGet]
    public List<Contact> Get()
    {
        return contactService.GetAllContacts();
    }

    [HttpPost]
    public IActionResult Post([FromBody] Contact contact) 
    {
        return contactService.SaveContact(contact) ? StatusCode(200) : StatusCode(409);
    }
}
