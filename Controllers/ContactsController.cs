using ContactsManager.Interface;
using ContactsManager.Models;
using ContactsManager.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContactsManager.Controllers
{
    [ApiController]
    [Route("/api[controller]")]
    public class ContactsController : ControllerBase
    {
        private readonly IContactRepository _repository;

        public ContactsController(IContactRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetContacts()
        {
            var contacts = _repository.GetAllContacts();
            return Ok(contacts);
        }

        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var contact = _repository.GetContactById(id);
            if (contact == null)
            {
                return NotFound();
            }
            return Ok(contact);
        }

        [HttpPost]
        public IActionResult CreateContact(Contact contact)
        {
            _repository.AddContact(contact);
            _repository.SaveChanges();
            return CreatedAtAction(nameof(GetContact), new { id = contact.Id }, contact);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateContact(int id, Contact updatedContact)
        {
            var existingContact = _repository.GetContactById(id);
            if (existingContact == null)
            {
                return NotFound();
            }

            existingContact.FirstName = updatedContact.FirstName;
            existingContact.LastName = updatedContact.LastName;

            _repository.UpdateContact(existingContact);
            _repository.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var contact = _repository.GetContactById(id);
            if (contact == null)
            {
                return NotFound();
            }

            _repository.DeleteContact(contact);
            _repository.SaveChanges();
            return NoContent();
        }
    }
}
