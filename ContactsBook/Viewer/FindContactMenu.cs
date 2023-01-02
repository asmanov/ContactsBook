namespace ContactsBook.Viewer
{
    internal class FindContactMenu : IMenu
    {
        void IMenu.ShowMenu()
        {
            Console.WriteLine("Enter name or/and last name or phone number");
        }
    }
}
