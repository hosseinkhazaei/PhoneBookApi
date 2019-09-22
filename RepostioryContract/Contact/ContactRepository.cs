using DataAccess.EF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entities.ContactEntity;

namespace RepostioryContract.Contact
{
    public class ContactRepository : IContactRepository
    {
        public int Add(Entities.ContactEntity.Contact contact)
        {
            PhoneBookDbContext db = new PhoneBookDbContext();
            var result = db.Add(contact);
            db.SaveChanges();
            return result.Entity.ContactId;
        }

        public void Delete(int contactId)
        {
            PhoneBookDbContext db = new PhoneBookDbContext();
            var contact = GetById(contactId);
            db.Remove(contact);
            db.SaveChanges();
        }

        public List<Entities.ContactEntity.Contact> GetAll()
        {
            List<Entities.ContactEntity.Contact> contacts = new List<Entities.ContactEntity.Contact>();
            PhoneBookDbContext db = new PhoneBookDbContext();
            contacts = db.Contacts.ToList();
            return contacts;
        }
        public Entities.ContactEntity.Contact GetById(int contactId)
        {
            Entities.ContactEntity.Contact contact = new Entities.ContactEntity.Contact();
            PhoneBookDbContext db = new PhoneBookDbContext();
            contact = db.Contacts.FirstOrDefault(c => c.ContactId == contactId);
            return contact;
        }

        public Entities.ContactEntity.Contact Update(Entities.ContactEntity.Contact contact)
        {
            PhoneBookDbContext db = new PhoneBookDbContext();
            db.Contacts.Update(contact);
            db.SaveChanges();
            return contact;
        }
    }
}
