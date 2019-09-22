using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ContactEntity
{
    public class Contact
    {
        public int ContactId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Family { get; set; }
        public int Gender { get; set; }
        public bool IsComapny { get; set; }
        [Required]
        public string Tel { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneNumberTwo { get; set; }
        [Required]
        public string AreaCode { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
