using System.Text.Json;

namespace backend
{
    public class ContactRepository
    {
        private const string jsonFilePath = "Contacts.json";

        public List<Contact> GetAllContacts()
        {
            string jsonString = File.ReadAllText(jsonFilePath);
            var contacts = JsonSerializer.Deserialize<List<Contact>>(jsonString);
            return contacts;
        }

        public void SaveContact(Contact newContact)
        {
            string jsonString = File.ReadAllText(jsonFilePath);
            var contacts = JsonSerializer.Deserialize<List<Contact>>(jsonString);

            contacts.Add(newContact);

            string updatedJsonString = JsonSerializer.Serialize(contacts, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(jsonFilePath, updatedJsonString);
        }
    }
}
