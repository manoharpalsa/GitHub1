using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact.Core.Entities;

namespace Contact.Core.Interfaces
{
    public interface IContactRepository
    {
        void Add(Entities.Contact b);
        void Edit(Entities.Contact b);
        void Remove(string Id);
        IEnumerable<Entities.Contact> GetContacts();
        Entities.Contact FindById(int Id);
    }
}
