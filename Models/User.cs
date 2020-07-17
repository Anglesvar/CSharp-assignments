using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4_CodeFIrstApproach.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public string email { get; set; }
        public bool IsActive { get; set; }
    }
}
