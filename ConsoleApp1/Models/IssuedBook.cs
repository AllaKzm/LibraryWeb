using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleApp1.Models
{
    public partial class IssuedBook
    {
        public byte[] IssueDate { get; set; }
        public byte[] ReturnDate { get; set; }
        public byte[] ReturnMark { get; set; }
        public long EmpId { get; set; }
        public long ReadId { get; set; }
        public long BookId { get; set; }

        public virtual Book Book { get; set; }
        public virtual Employee Emp { get; set; }
        public virtual Reader Read { get; set; }
    }
}
