
using ContactsBook.Controlers;
using ContactsBook.Models;
using ContactsBook.Viewer;
string path = "mycontacts.txt";
using (ContactStorage mycontacts = new ContactStorage(path))
{
    Menu.MainMenu();
    MainMenuControler.CreateContac(Console.ReadLine());
    string ch = Console.ReadLine();

}


