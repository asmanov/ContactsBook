using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
