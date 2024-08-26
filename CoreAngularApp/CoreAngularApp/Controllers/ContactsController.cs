using CoreAngularApp.Data;
using CoreAngularApp.Models.Domain;
using CoreAngularApp.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreAngularApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        public readonly CoreAngularAppDbContext dbContext;
        public ContactsController(CoreAngularAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllContacts()
        {
            var contacts = dbContext.Contacts.ToList();
            return Ok(contacts);
        }

        [HttpPost]
        public IActionResult AddContact(AddContactRequest contactRequest)
        {
            var domainModelContact = new Contact
            {
                ID = Guid.NewGuid(),
                Name = contactRequest.Name,
                Phone = contactRequest.Phone,
                Email = contactRequest.Email,
                Favorite = contactRequest.Favorite
            };
            dbContext.Contacts.Add(domainModelContact);
            dbContext.SaveChanges();
            return Ok(domainModelContact);              
        }
    }
}
