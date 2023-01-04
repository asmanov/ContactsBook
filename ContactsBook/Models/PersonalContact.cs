namespace ContactsBook.Models
{
    internal class PersonalContact : IContact
    {
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public Address Address { get; set; } = null;
        public string Phone2 { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Birthday { get; set; }
        public string Organization { get; set; }
        public string Position { get; set; }

        private static PersonalContact _instance;
        private PersonalContact() { }
        public static PersonalContact GetPersonalContact()
        {
            if (_instance == null)
            {
                _instance = new PersonalContact();
            }
            return _instance;
        }
    }
}
