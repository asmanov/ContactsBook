using ContactsBook.Models;
using ContactsBook.Viewer;

namespace ContactsBook.Controlers
{
    internal static class MainMenuControler
    {
        internal static void CreateContac(string ch)
        {
            Console.Clear();
            if (ch == "1")
            {
                Menu.CategorySelect();
            }
            if (ch == "2") Menu.FindMenu();
        }
        internal static void SelectCategory(string ch)
        {
            ContactCreator creator;
            IContact contact;
            if(ch == "1")
            {
                creator = new WorkContactCreator();
                contact = creator.CreatorMethod();
                Menu.AddInfoMenuW();
            }
            if(ch == "2")
            {
                creator = new PersonalContactCreator();
                contact = creator.CreatorMethod();
                Menu.AddInfoMenuP();
            }
        }

    }
}
