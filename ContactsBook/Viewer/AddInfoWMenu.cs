namespace ContactsBook.Viewer
{
    internal class AddInfoWMenu : IMenu
    {
        void IMenu.ShowMenu()
        {
            Console.WriteLine("=====Enter contact's info=====\n\n" +
                "Name. Enter - 1\n" +
                "Last Name. Enter - 2\n" +
                "Phone. Enter - 3\n" +
                "Phone 2. Enter - 4\n" +
                "Email. Enter - 5\n" +
                "Address. Enter - 6\n" +
                "Organisation. Enter - 7\n" +
                "Position. Enter - 8");
        }
    }
}
