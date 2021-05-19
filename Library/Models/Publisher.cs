using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleApp1.Models
{
    public partial class Publisher
    {
        public Publisher()
        {
            Books = new HashSet<Book>();
        }

        public long PubId { get; set; }
        public byte[] PublicistTitle { get; set; }
        public byte[] City { get; set; }
        public byte[] Address { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
