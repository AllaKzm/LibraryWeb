using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleApp1.Models
{
    public partial class Genre
    {
        public Genre()
        {
            Books = new HashSet<Book>();
        }

        public long GenId { get; set; }
        public byte[] GenTitle { get; set; }
        public byte[] Description { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
