using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BookLibrary.Models
{
    public partial class Authors
    {
        public Authors()
        {
            AuthorIsbn = new HashSet<AuthorIsbn>();
        }

        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<AuthorIsbn> AuthorIsbn { get; set; }
    }
}
