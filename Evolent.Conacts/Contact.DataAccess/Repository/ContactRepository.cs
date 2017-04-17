using Contact.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.DataAccess.Repository
{
    public class ContactRepository : IContactRepository
    {
        ContactDataContext context = new ContactDataContext();
        public void Add(Core.Entities.Contact b)
        {
            context.Contacts.Add(b);
            context.SaveChanges();

        }

        public void Edit(Core.Entities.Contact b)
        {
            context.Entry(b).State = System.Data.Entity.EntityState.Modified;
        }

        public void Remove(string Id)
        {
            Core.Entities.Contact b = context.Contacts.Find(Id);
            context.Contacts.Remove(b);
            context.SaveChanges();
        }

        public IEnumerable<Core.Entities.Contact> GetContacts()
        {
            return context.Contacts;
        }

        public Core.Entities.Contact FindById(int Id)
        {
            var c = (from r in context.Contacts where r.Id == Id select r).FirstOrDefault();
            return c;
        }
    }
}
