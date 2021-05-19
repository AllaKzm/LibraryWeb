using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleApp1.Models
{
    public partial class Book
    {
        public long BookId { get; set; }
        public byte[] BookTitle { get; set; }
        public byte[] Author { get; set; }
        public byte[] PubYear { get; set; }
        public long GenId { get; set; }
        public long PubId { get; set; }

        public virtual Genre Gen { get; set; }
        public virtual Publisher Pub { get; set; }
    }
}
