using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.DataAccess
{
    public class ContactDataContext : DbContext
    {
        public ContactDataContext() : base("name=contactconnectionstring")
       {

        }
        public IDbSet<Contact.Core.Entities.Contact> Contacts { get; set; }

    }
}
