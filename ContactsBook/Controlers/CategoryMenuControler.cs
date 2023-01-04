using ContactsBook.Models;
using ContactsBook.Viewer;

namespace ContactsBook.Controlers
{
    internal class CategoryMenuControler : Controler, IControler
    {
        
        public void InputMenu(ref IMenu menu, ref IControler controler, string key, ref bool flag)
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
                //PersonalContactCreator personalContactCreator = new PersonalContactCreator();
                //contactCreator = new PersonalContactCreator();
                //contact = (PersonalContact)contactCreator.CreatorMethod();
            }
            flag = false;
        }
    }
}
