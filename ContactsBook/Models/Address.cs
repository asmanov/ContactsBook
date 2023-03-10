namespace ContactsBook.Models
{
    internal class Address
    {
        /// <summary>
        /// 
        /// </summary>
        internal string Countre { get; set; } = string.Empty;
        internal string City { get; set; } = string.Empty;
        internal string Strite { get; set; } = string.Empty;
        internal string Building { get; set; } = string.Empty;
        internal string Apartment { get; set; } = string.Empty;
        internal string PostCode { get; set; } = string.Empty;
        public Address()
        {

        }
        public override string ToString()
        {
            return $"{Countre}, {City}, Str. {Strite}, building {Building}, apartment {Apartment}, postcode {PostCode}";
        }
    }
}
