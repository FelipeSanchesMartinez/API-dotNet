using ContactAPI.Data;
using ContactAPI.Model;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace ContactAPI.Services
{
    public class ContactService : IContactService
    {
        SqlContext _sqlContext;

        public ContactService(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public void Insert(ContactModel contact)

        {
            contact.CreatAt = DateTime.Now;
            _sqlContext.Contato.Add(contact);
            _sqlContext.SaveChanges();
        }

        public void Update(long id, ContactModel contact)

        {
            ContactModel contactUpdate = _sqlContext.Contato.AsNoTracking().FirstOrDefault(contact => contact.Id == id);
            if (contactUpdate != null)
                contact.UpdatedAt = DateTime.Now;
            _sqlContext.Contato.Add(contact);
            _sqlContext.SaveChanges();
        }
    }
}




    
