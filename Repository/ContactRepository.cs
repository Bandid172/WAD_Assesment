using ContactsManager.Interface;
using ContactsManager.Models;
using ContactsManager.Services;

namespace ContactsManager.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly ApplicationDbContext _context;

        public ContactRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Contact> GetAllContacts()
        {
            return _context.Contacts.ToList();
        }

        public Contact GetContactById(int id)
        {
            return _context.Contacts.Find(id);
        }

        public void AddContact(Contact contact)
        {
            _context.Contacts.Add(contact);
        }

        public void UpdateContact(Contact contact)
        {
            // The context tracks changes automatically
        }

        public void DeleteContact(Contact contact)
        {
            _context.Contacts.Remove(contact);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
