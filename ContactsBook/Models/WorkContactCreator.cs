namespace ContactsBook.Models
{
    internal class WorkContactCreator : ContactCreator
    {
        public override IContact CreatorMethod()
        {
            return WorkContact.GetWorkContact();
        }
    }
}
