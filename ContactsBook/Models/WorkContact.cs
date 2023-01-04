namespace ContactsBook.Models
{
    internal class WorkContact : IContact
    {
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Phone2 { get; set; } = string.Empty;
        public Address Address { get; set; } = null;
        public string Organization { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public string Status { get ; set; }
        public string Birthday { get ; set; }

        private static WorkContact _instance;
        private WorkContact() { }
        public static WorkContact GetWorkContact()
        {
            if( _instance == null)
            {
                _instance = new WorkContact();
            }
            return _instance;
        }
    }
}
