using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.DataAccess
{
    public class ContactDbInitalize : DropCreateDatabaseIfModelChanges<ContactDataContext>
    {
        protected override void Seed(ContactDataContext context)
        {
            context.Contacts.Add(
                  new Core.Entities.Contact
                  {
                      Id = 1,
                      FirstName = "John",
                      LastName = "Wright",
                      Email = "john.wright@gmail.com",
                      PhoneNumber = "123-234-1234",
                      IsActive = true
                  });

            context.Contacts.Add(
                  new Core.Entities.Contact
                  {
                      Id = 2,
                      FirstName = "Don",
                      LastName = "Miller",
                      Email = "don.miller@gmail.com",
                      PhoneNumber = "342-234-1256",
                      IsActive = true
                  });

            context.SaveChanges();

            base.Seed(context);

        }
    }
}
