using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Linq;
using backend.Repositories;

namespace backend.Services
{
    public class ContactService
    {
        private ContactRepository contactRepository = new ContactRepository();

        public List<Contact> GetAllContacts()
        {
            return contactRepository.GetAllContacts();
        }

        public bool SaveContact(Contact newContact)
        {
            if (EmailAlreadyExists(newContact.Email))
            {
                return false;
            }
            else
            {
                contactRepository.SaveContact(newContact);
                return true;
            }

        }

        private bool EmailAlreadyExists(string email)
        {
            List<Contact> contacts = contactRepository.GetAllContacts();
            bool emailExists = contacts.Any(contact => contact.Email == email);

            return emailExists;
        }
    }
}
