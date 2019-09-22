using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.ContactEntity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceContract.Contact;

namespace phoneBook.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService contactService;

        public ContactController(IContactService contactService)
        {
            this.contactService = contactService;
        }
        // GET: api/Contact
        [HttpGet]
        public IActionResult Get()
        {
            List<Contact> contacts = new List<Contact>();
            contacts = contactService.GetAll();
            return Ok(contacts);
        }

        // GET: api/Contact/5
        /// <summary>
        /// GetBy Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var result = contactService.GetById(id);
            return Ok(result);
        }

        // POST: api/Contact
        [HttpPost]
        public IActionResult Post([FromBody] Contact contact)
        {
            if (ModelState.IsValid)
            {
                var result = contactService.Add(contact);
                return Created($"/api/Contact/{result}", "باموفقیت ثبت شد");
            }
            else
            {
                return BadRequest(ModelState);
            }

        }

        // PUT: api/Contact/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]  Contact value)
        {
            var contact = contactService.GetById(id);
            if (contact == null)
            {
                return BadRequest("Contact NotFound");
            }
            if (ModelState.IsValid)
            {
                var result = contactService.update(id, value);
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            contactService.Delete(id);
            return Ok();
        }
    }
}
