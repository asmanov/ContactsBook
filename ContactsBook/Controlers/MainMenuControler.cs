using ContactsBook.Viewer;

namespace ContactsBook.Controlers
{
    internal class MainMenuControler : IControler
    {
        void IControler.InputMenu(ref IMenu menu, ref IControler controler, string key)
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
            }
        }
    }
}
