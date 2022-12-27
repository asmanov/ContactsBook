using System.Text.Json;
using System.Text.Json.Serialization;

namespace ContactsBook.Models
{
    internal class ContactStorage : IDisposable
    {
        public List<IContact> Contacts { get; set; } = null;
        public string Path { get; set; }
        public ContactStorage(string path)
        {
            Path = path;
            if(File.Exists(Path))
            {
                string file = File.ReadAllText(path);
                Contacts = JsonSerializer.Deserialize<List<IContact>>(file);
            }
            else Contacts = new List<IContact>();
        }
        public IEnumerable<IContact> CategoriFilter(IContact item)
        {
            var categorii = Contacts.Where<IContact>(x => x.GetType() == item.GetType()).ToList<IContact>();
            return categorii;
        }
        public IEnumerable<IContact> NameFilter(string item)
        {
            var names = Contacts.Where<IContact>(x => x.Name.Contains(item) || x.LastName.Contains(item)|| x.Phone.Contains(item)).ToList<IContact>();
            return names;
        }
        public IContact FindContact(string firstname, string lastname)
        {
            var oneContact = Contacts.FirstOrDefault(x=> x.Name == firstname && x.LastName == lastname, new PersonalContact());
            return oneContact;
        }
        public IContact FindContact(string phone)
        {
            var oneContact = Contacts.FirstOrDefault(x => x.Phone == phone || x.Phone2 == phone, new PersonalContact());
            return oneContact;
        }
        public void Dispose()
        {
            string file = JsonSerializer.Serialize(Contacts);
            File.WriteAllText(Path, file);
        }
    }
}
