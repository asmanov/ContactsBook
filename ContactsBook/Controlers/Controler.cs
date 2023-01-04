using ContactsBook.Models;
using ContactsBook.Viewer;

namespace ContactsBook.Controlers
{
    internal abstract class Controler : IControler
    {
        public virtual void InputMenu(ref IMenu menu, ref IControler controler, string key, ref bool flag)
        {
            
        }
        public virtual void InputMenu(ref IMenu menu, ref IControler controler, string key, ref bool flag, ContactStorage contacts)
        {

        }

    }
}
