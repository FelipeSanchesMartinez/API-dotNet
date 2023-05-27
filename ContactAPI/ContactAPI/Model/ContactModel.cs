using System.ComponentModel.DataAnnotations;

namespace ContactAPI.Model
{
    public class ContactModel: Entity
    {
        public string Name { get; set; }
        public int Contact { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string EmailAddress { get; set; }
    }
}
