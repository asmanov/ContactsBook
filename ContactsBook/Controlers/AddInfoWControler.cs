using ContactsBook.Models;
using ContactsBook.Viewer;

namespace ContactsBook.Controlers
{
    internal class AddInfoWControler : Controler, IControler
    {
        public void  InputMenu(ref IMenu menu, ref IControler controler, string key, ref bool flag)
        {
            WorkContactCreator creator = new WorkContactCreator();
            IContact contact = creator.CreatorMethod();
            if (key == "1") contact.Name = Console.ReadLine();
            if (key == "2") contact.LastName = Console.ReadLine();
            if (key == "3") contact.Phone = Console.ReadLine();
            if (key == "4") contact.Phone2 = Console.ReadLine();
            if (key == "5") contact.Email = Console.ReadLine();
            if (key == "6") contact.Address = new Address();
            if (key == "7") contact.Organization = Console.ReadLine();
            if (key == "8") contact.Position = Console.ReadLine();
            //if(key == "0")
        }
    }
}