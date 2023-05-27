using ContactAPI.Model;

namespace ContactAPI.Services
{
    public interface IContactService
    {
        void Insert(ContactModel contact);
        void Update(long id, ContactModel contact);
    }
}