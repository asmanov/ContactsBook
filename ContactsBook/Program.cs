
using ContactsBook.Controlers;
using ContactsBook.Models;
using ContactsBook.Viewer;

string path = "mycontact.txt";
using(ContactStorage mycontacts = new ContactStorage(path))
{
    IMenu menu = new MainMenu();
    IControler controler = new MainMenuControler();
    IContact contact;
    bool flag = true;
    while(flag)
    {
        Console.Clear();
        menu.ShowMenu();
        string key = Console.ReadLine();
        controler.InputMenu(ref menu, ref controler, key, ref flag);
    }
    flag = true;
    while (flag)
    {
        Console.Clear();
        menu.ShowMenu();
        string key = Console.ReadLine();
        controler.InputMenu(ref menu, ref controler, key, ref flag, mycontacts);
    }
}
