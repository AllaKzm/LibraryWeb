using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleApp1.Models
{
    public partial class Employee
    {
        public long EmpId { get; set; }
        public byte[] Name { get; set; }
        public byte[] BirthDate { get; set; }
        public byte[] Gender { get; set; }
        public byte[] Address { get; set; }
        public byte[] Phone { get; set; }
        public byte[] PassportData { get; set; }
        public long PositionId { get; set; }

        public virtual Position Position { get; set; }
    }
}
