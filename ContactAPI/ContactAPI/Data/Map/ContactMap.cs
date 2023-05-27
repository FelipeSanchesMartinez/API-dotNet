using ContactAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ContactAPI.Data.Map
{
    public class ContactMap : IEntityTypeConfiguration<ContactModel>
    {
        public void Configure(EntityTypeBuilder<ContactModel> builder)
        {
            builder.Property(contact => contact.CreatAt).IsRequired();
            builder.Property(contact => contact.UpdatedAt).IsRequired();
            builder.Property(contact => contact.DeletedAt).IsRequired();
            builder.Property(contact => contact.Id).IsRequired();
            builder.Property(contact => contact.Name)
                .HasAnnotation("MinLength", 5)
                .IsRequired();

            builder.Property(contact => contact.Contact)
                   .HasMaxLength(9)
                   .IsRequired();

            builder.Property(contact => contact.EmailAddress)
                   .HasMaxLength(100)
                   .IsRequired()
              .HasAnnotation("MaxLength", 100)
                   .HasAnnotation("MinLength", 6)
                   .HasAnnotation("RegularExpression", @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
    }
    }

