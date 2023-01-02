using ContactsBook.Models;
using ContactsBook.Viewer;

namespace ContactsBook.Controlers
{
    internal interface IControler
    {
        internal void InputMenu(ref IMenu menu, ref IControler controler, string key);
    }
}
