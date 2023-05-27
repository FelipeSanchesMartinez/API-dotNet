using ContactAPI.Data;
using ContactAPI.Model;
using ContactAPI.Services;
using ContactAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpPost()]
        public IActionResult Insert([FromBody]InsertContactViewModel viewModel)
        {
            ContactModel data = _contactService.Insert(viewModel);
            return Ok(data);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            ContactModel contact = _sqlContext.Contato.AsNoTracking().FirstOrDefault(contact => contact.Id == id);
            if (contact == null)
                return NotFound();

            return Ok(contact);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, UpdateContactViewModel viewModel)
        {
            viewModel.Id = id;
            ContactModel contact = _contactService.Update(viewModel);
            return Ok(contact);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(long id) 
        {
            ContactModel contactDeleted = _sqlContext.Contato.FirstOrDefault(contact => contact.Id == id);
            if (contactDeleted == null)
                return NotFound();
            contactDeleted.Deleted = true;
            _sqlContext.SaveChanges();
            return NoContent();
        }

    }
}
