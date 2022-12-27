using ContactsBook.Models;

namespace ContactsBook.Viewer
{
    internal static class ContactsViewer
    {
        public static void ShowListContacts(List<IContact> contacts)
        {
            contacts.ForEach(x => Console.WriteLine($"{x.Name} {x.LastName}: {x.Phone}"));
        }
        public static void ShowContact(PersonalContact contact)
        {
            if (contact.Name != string.Empty) Console.WriteLine($"Name:\t{contact.Name}\n");
            if (contact.LastName != string.Empty) Console.WriteLine($"Last Name:\t{contact.LastName}\n");
            if (contact.Status != string.Empty) Console.WriteLine($"Status:\t{contact.Status}\n");
            if (contact.Phone != string.Empty) Console.WriteLine($"Phone nomber:\t{contact.Phone}\n");
            if (contact.Phone2 != string.Empty) Console.WriteLine($"Phone nomber:\t{contact.Phone2}\n");
            if (contact.Email != string.Empty) Console.WriteLine($"Phone nomber:\t{contact.Email}\n");
            if (contact.Birthday != null) Console.WriteLine($"Birthday: {contact.Birthday}");
            if (contact.Address != null) Console.WriteLine($"Adress:\t{contact.Address.ToString}\n");
        }
        public static void ShowContact(WorkContact contact)
        {
            if (contact.Name != string.Empty) Console.WriteLine($"Name:\t{contact.Name}\n");
            if (contact.LastName != string.Empty) Console.WriteLine($"Last Name:\t{contact.LastName}\n");
            if (contact.Phone != string.Empty) Console.WriteLine($"Phone nomber:\t{contact.Phone}\n");
            if (contact.Phone2 != string.Empty) Console.WriteLine($"Phone nomber:\t{contact.Phone2}\n");
            if (contact.Email != string.Empty) Console.WriteLine($"Phone nomber:\t{contact.Email}\n");
            if (contact.Organization != null) Console.WriteLine($"Organization:\t{contact.Organization}");
            if (contact.Position != string.Empty) Console.WriteLine($"Position:\t{contact.Position}\n");
            if (contact.Address != null) Console.WriteLine($"Adress:\t{contact.Address.ToString}\n");
        }
    }
}
