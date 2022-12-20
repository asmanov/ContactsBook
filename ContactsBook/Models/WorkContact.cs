namespace ContactsBook.Models
{
    internal class WorkContact : IContact
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Phone { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Phone2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Address Address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Organization { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public WorkContact()
        {

        }
    }
}
