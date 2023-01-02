using ContactsBook.Models;
using ContactsBook.Viewer;

namespace ContactsBook.Controlers
{
    internal class CategoryMenuControler : Controler, IControler
    {
        
        void IControler.InputMenu(ref IMenu menu, ref IControler controler, string key)
        {
            //ContactCreator contactCreator;
            //IContact contact;
            if (key == "1")
            {
                menu = new AddInfoWMenu();
                controler = new AddInfoWControler();
                //contactCreator = new WorkContactCreator();
                //contact = (WorkContact)contactCreator.CreatorMethod();
            }
            else if (key == "2")
            {
                menu = new AddInfoPMenu();
                controler = new AddInfoPControler();
                PersonalContactCreator personalContactCreator = new PersonalContactCreator();
                //contactCreator = new PersonalContactCreator();
                //contact = (PersonalContact)contactCreator.CreatorMethod();
            }
        }
    }
}
