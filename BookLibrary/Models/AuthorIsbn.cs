using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BookLibrary.Models
{
    public partial class AuthorIsbn
    {
        public int AuthorId { get; set; }
        public string Isbn { get; set; }

        public virtual Authors Author { get; set; }
        public virtual Titles IsbnNavigation { get; set; }
    }
}
