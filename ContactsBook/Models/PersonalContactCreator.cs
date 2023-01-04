namespace ContactsBook.Models
{
    internal class PersonalContactCreator : ContactCreator
    {
        public override IContact CreatorMethod()
        {
            return PersonalContact.GetPersonalContact();
        }
    }
}
