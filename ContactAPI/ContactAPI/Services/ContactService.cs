using ContactAPI.Data;
using ContactAPI.Model;
using ContactAPI.ViewModels;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using System.Xml.Linq;

namespace ContactAPI.Services
{
    public class ContactService : IContactService
    {
        SqlContext _sqlContext;

        public ContactService(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public ContactModel Insert(InsertContactViewModel viewModel)

        {
            ContactModel newContact = new ContactModel()
            {
                Name = viewModel.Name,
                Contact = viewModel.Contact,
                EmailAddress = viewModel.EmailAddress
            };
            newContact.CreatAt = DateTime.Now;
            _sqlContext.Contato.Add(newContact);
            _sqlContext.SaveChanges();
            return newContact;

        }

        public ContactModel Update(UpdateContactViewModel viewModel)

        {
            ContactModel contactUpdate = new ContactModel()
            {
                Name = viewModel.Name,
                Contact = viewModel.Contact,
                EmailAddress = viewModel.EmailAddress
            };

            if (contactUpdate != null)
                contactUpdate.UpdatedAt = DateTime.Now;
            _sqlContext.Contato.Add(contactUpdate);
            _sqlContext.SaveChanges();
            return contactUpdate;
        }
    }
}




    
