using System.Collections.Generic;

namespace RepostioryContract.Contact
{
    public interface IContactRepository
    {
        List<Entities.ContactEntity.Contact> GetAll();
        Entities.ContactEntity.Contact GetById(int contactId);
        int Add(Entities.ContactEntity.Contact contact);
        void Delete(int contactId);
        Entities.ContactEntity.Contact Update(Entities.ContactEntity.Contact contact);
    }
}
