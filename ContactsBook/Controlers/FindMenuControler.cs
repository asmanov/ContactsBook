using ContactsBook.Models;
using ContactsBook.Viewer;

namespace ContactsBook.Controlers
{
    internal class FindMenuControler : Controler, IControler
    {
        public void InputMenu(ref IMenu menu, ref IControler controler, string key, ref bool flag)
        {
           
        }

        public void InputMenu(ref IMenu menu, ref IControler controler, string key, ref bool flag, ContactStorage contacts)
        {
            string[] words = key.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            if (words.Length == 1)
            {
                List<IContact> temp = contacts.NameFilter(words[0]);
                if (temp.LongCount() == 1) ContactsViewer.ShowContact(temp[0]);
                else if (temp.LongCount() > 1) ContactsViewer.ShowListContacts(temp);
            }
            else if (words.Length > 1)
            {
                ContactsViewer.ShowContact(contacts.FindContact(words[0], words[1])); 
            }
            Console.ReadLine();
            menu = new MainMenu();
            controler = new MainMenuControler();
        }
    }
}
