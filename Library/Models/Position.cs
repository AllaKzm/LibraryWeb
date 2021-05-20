using System;
using System.Collections.Generic;

#nullable disable

namespace Library.Models
{
    public partial class Position
    {
        public Position()
        {
            Employees = new HashSet<Employee>();
        }

        public long PositionId { get; set; }
        public string PositionTitle { get; set; }
        public double Salary { get; set; }
        public string Duties { get; set; }
        public string Demands { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
