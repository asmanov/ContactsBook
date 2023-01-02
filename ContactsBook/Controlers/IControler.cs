using ContactsBook.Viewer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsBook.Controlers
{
    internal interface IControler
    {
        internal void InputMenu(ref IMenu menu, ref IControler controler, string key);
    }
}
