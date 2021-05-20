using System;
using System.Collections.Generic;

#nullable disable

namespace Library.Models
{
    public partial class IssuedBook
    {
        public DateTime IssueDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string ReturnMark { get; set; }
        public long EmpId { get; set; }
        public long ReadId { get; set; }
        public long BookId { get; set; }

        public virtual Book Book { get; set; }
        public virtual Employee Emp { get; set; }
        public virtual Reader Read { get; set; }
    }
}
