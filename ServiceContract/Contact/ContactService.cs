using Entities.ContactEntity;
using RepostioryContract.Contact;
using System;
using System.Collections.Generic;
namespace ServiceContract.Contact
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            this.contactRepository = contactRepository;
        }
        public int Add(Entities.ContactEntity.Contact contact)
        {
            var result = contactRepository.Add(contact);
            return result;
        }

        public void Delete(int contactId)
        {
            contactRepository.Delete(contactId);
        }

        public List<Entities.ContactEntity.Contact> GetAll()
        {
            List<Entities.ContactEntity.Contact> contacts = new List<Entities.ContactEntity.Contact>();
            contacts = contactRepository.GetAll();
            return contacts;
        }

        public Entities.ContactEntity.Contact GetById(int contactId)
        {
            Entities.ContactEntity.Contact contact = new Entities.ContactEntity.Contact();
            contact = contactRepository.GetById(contactId);
            return contact;
        }

        public Entities.ContactEntity.Contact update(int contactId, Entities.ContactEntity.Contact contact)
        {
            var contactByid =GetById(contactId);
            contactByid.Adress = contact.Adress;
            contactByid.AreaCode = contact.AreaCode;
            contactByid.Email = contact.Email;
            contactByid.Family = contact.Family;
            contactByid.Gender = contact.Gender;
            contactByid.IsComapny = contact.IsComapny;
            contactByid.Name = contact.Name;
            contactByid.PhoneNumber = contact.PhoneNumber;
            contactByid.PhoneNumberTwo = contact.PhoneNumberTwo;
            contactByid.Tel = contact.Tel;
           var updated= contactRepository.Update(contactByid);
            return updated;
        }
    }
}
