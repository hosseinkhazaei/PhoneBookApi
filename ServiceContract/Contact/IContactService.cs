using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.ContactEntity;
namespace ServiceContract.Contact
{
    public interface IContactService
    {
        List<Entities.ContactEntity.Contact> GetAll();
        Entities.ContactEntity.Contact GetById(int contactId);
        int Add(Entities.ContactEntity.Contact contact);
        void Delete(int contactId);
        Entities.ContactEntity.Contact update(int contactId, Entities.ContactEntity.Contact contact);
    }
}
