namespace ContactsBook.Viewer
{
    internal class ChCategoryMenu : IMenu
    {
        void IMenu.ShowMenu()
        {
            Console.WriteLine("=====Chose contact's category=====\n" +
                "Work contact. Enter - 1\n" +
                "Personal contact. Enter - 2");
        }
    }
}
