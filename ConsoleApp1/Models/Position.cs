using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleApp1.Models
{
    public partial class Position
    {
        public Position()
        {
            Employees = new HashSet<Employee>();
        }

        public long PositionId { get; set; }
        public byte[] PositionTitle { get; set; }
        public double Salary { get; set; }
        public byte[] Duties { get; set; }
        public byte[] Demands { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
