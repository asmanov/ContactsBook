namespace ContactsBook.Models
{
    internal class PersonalContact : IContact
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Phone { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Address Address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Phone2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Status { get; set; } = string.Empty;
        public DateOnly Birthday { get; set; }
        public PersonalContact()
        {

        }
    }
}
