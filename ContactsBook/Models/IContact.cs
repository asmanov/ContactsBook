namespace ContactsBook.Models
{
    internal interface IContact
    {
        string Name { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string Phone { get; set; }
        string Phone2 { get; set; }
        Address Address { get; set; }
        string Organization { get; set; }
        string Position { get; set; }
        string Status { get; set; }
        string Birthday { get; set; }
    }
}
