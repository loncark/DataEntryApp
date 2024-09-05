using System.Collections.Generic;
using System.IO;
using System.Text.Json;


namespace backend
{
    public class ContactService
    {
        public List<Contact> GetAllContacts()
        {
            string jsonString = File.ReadAllText("Contacts.json");
            Console.WriteLine(jsonString);
            var contacts = JsonSerializer.Deserialize<List<Contact>>(jsonString);
            return contacts;
        }
    }
}
