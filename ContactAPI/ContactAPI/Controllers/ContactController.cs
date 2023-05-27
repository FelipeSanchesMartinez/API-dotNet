using ContactAPI.Data;
using ContactAPI.Model;
using ContactAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContactAPI.Controllers
{
    [ApiController]
    [Route("/contact")]
    public class ContactController : ControllerBase
    {
     SqlContext _sqlContext;
     IContactService _contactService;

        public ContactController(SqlContext sqlContext, IContactService contactService)
        {
            _sqlContext = sqlContext;
            _contactService = contactService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<ContactModel> contact = _sqlContext.Contato.Where(contact => contact.Deleted == false).ToList();
            return Ok(contact);
        }



    }
}
