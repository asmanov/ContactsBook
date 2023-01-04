using ContactsBook.Viewer;

namespace ContactsBook.Controlers
{
    internal class MainMenuControler : Controler, IControler
    {
        public void InputMenu(ref IMenu menu, ref IControler controler, string key, ref bool flag)
        {
            if (key == "1")
            {
                menu = new ChCategoryMenu();
                controler = new CategoryMenuControler();
            }
            else if (key == "2")
            {
                menu = new FindContactMenu();
                controler = new FindMenuControler();
                flag = false;
            }
        }
    }
}
