using System;
using System.Collections.Generic;

#nullable disable

namespace Library.Models
{
    public partial class Reader
    {
        public long ReadId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string PassportData { get; set; }
    }
}
