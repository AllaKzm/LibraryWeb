using System;
using System.Collections.Generic;

#nullable disable

namespace Library.Models
{
    public partial class Book
    {
        public long BookId { get; set; }
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public DateTime PubYear { get; set; }
        public long GenId { get; set; }
        public long PubId { get; set; }

        public virtual Genre Gen { get; set; }
        public virtual Publisher Pub { get; set; }
    }
}
