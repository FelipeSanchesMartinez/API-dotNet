using ContactAPI.Model;
using ContactAPI.ViewModels;

namespace ContactAPI.Services
{
    public interface IContactService
    {
        ContactModel Insert(InsertContactViewModel viewModel);
        ContactModel Update(UpdateContactViewModel viewModel);
    }
}