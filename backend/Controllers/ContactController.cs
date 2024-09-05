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
}
