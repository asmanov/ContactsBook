
using ContactsBook.Controlers;
using ContactsBook.Models;
using ContactsBook.Viewer;

string path = "mycontact.txt";
using(ContactStorage mycontacts = new ContactStorage(path))
{
    IMenu menu = new MainMenu();
    IControler controler = new MainMenuControler();
    IContact contact;
    while(true)
    {
        Console.Clear();
        menu.ShowMenu();
        string key = Console.ReadLine();
        controler.InputMenu(ref menu, ref controler, key);
    }
}
