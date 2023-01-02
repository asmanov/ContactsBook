namespace ContactsBook.Viewer
{
    internal class MainMenu : IMenu
    {
        void IMenu.ShowMenu()
        {
            Console.WriteLine("=============MENU==========\n");
            Console.WriteLine("1. Create contact. Enter - 1\n2. Find contact. Enter - 2\n3. Exit. Enter - 3\n");
        }
    }
}
