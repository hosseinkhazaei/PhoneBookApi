using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace phoneBook.Models
{
    public class ContactDTO
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public bool Gender { get; set; }
        public bool IsComapny { get; set; }
        public string Tel { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneNumberTwo { get; set; }
        public string AreaCode { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
    }
}
