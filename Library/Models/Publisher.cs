using System;
using System.Collections.Generic;

#nullable disable

namespace Library.Models
{
    public partial class Publisher
    {
        public Publisher()
        {
            Books = new HashSet<Book>();
        }

        public long PubId { get; set; }
        public string PublicistTitle { get; set; }
        public string City { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
