namespace ContactsBook.Viewer
{
    internal class AddInfoWMenu : IMenu
    {
        void IMenu.ShowMenu()
        {
            Console.WriteLine("========Enter contact's info=====\n\n" +
                "\tName. Enter - 1\n" +
                "\tLast Name. Enter - 2\n" +
                "\tPhone. Enter - 3\n" +
                "\tPhone 2. Enter - 4\n" +
                "\tEmail. Enter - 5\n" +
                "\tAddress. Enter - 6\n" +
                "\tOrganisation. Enter - 7\n" +
                "\tPosition. Enter - 8");
        }
    }
}
