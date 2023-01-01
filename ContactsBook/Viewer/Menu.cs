namespace ContactsBook.Viewer
{
    internal static class Menu
    {

        public static void MainMenu()
        {
            Console.WriteLine("=============MENU==========\n");
            Console.WriteLine("1. Create contact. Enter - 1\n2. Find contact. Enter - 2\n3. Exit. Enter - 3\n");
        }
        public static void CategorySelect()
        {
            Console.WriteLine("Select category of contact\n- for work. Enter - 1\n- personal. Enter - 2");
        }
        public static void AddInfoMenuP()
        {
            Console.WriteLine("Enter contact`s information\n" +
                "Name - 1\n" +
                "LastName - 2\n" +
                "Email - 3\n" +
                "Phone - 4\n" +
                "Phone2 - 5\n" +
                "Address - 6\n"+
                "Status - 7\n" +
                "Birthday - 8");
        }
        public static void AddInfoMenuW()
        {
            Console.WriteLine("Enter contact`s information\n" +
                "Name - 1\n" +
                "LastName - 2\n" +
                "Email - 3\n" +
                "Phone - 4\n" +
                "Phone2 - 5\n" +
                "Address - 6\n"+
                "Organisation - 7\n" +
                "Position - 8");
        }
        internal static void FindMenu()
        {
            Console.WriteLine("Enter name or/and lastname or phone");
        }
    }
}

