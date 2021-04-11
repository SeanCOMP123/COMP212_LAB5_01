using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BookLibrary.Models
{
    public partial class Titles
    {
        public Titles()
        {
            AuthorIsbn = new HashSet<AuthorIsbn>();
        }

        public string Isbn { get; set; }
        public string Title { get; set; }
        public int EditionNumber { get; set; }
        public string Copyright { get; set; }

        public virtual ICollection<AuthorIsbn> AuthorIsbn { get; set; }
    }
}
