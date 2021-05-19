using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleApp1.Models
{
    public partial class Reader
    {
        public long ReadId { get; set; }
        public byte[] Name { get; set; }
        public byte[] BirthDate { get; set; }
        public byte[] Gender { get; set; }
        public byte[] Address { get; set; }
        public byte[] Phone { get; set; }
        public byte[] PassportData { get; set; }
    }
}
