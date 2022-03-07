using System;
using System.ComponentModel.DataAnnotations;

namespace Week11Day1Demo.Models
{
    public class Student
    {
        [Key]
        public int RollNo { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }
        
        public double Percentage { get; set; }
    }
}
