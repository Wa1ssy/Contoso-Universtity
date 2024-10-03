﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniverstity.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "Money")]
        public decimal Budget { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        /*
         */
        public Student? Status { get; set; }
        public int? StudentId { get; set; }
        public string Aadress {  get; set; }
        [StringLength (30, MinimumLength = 5)]
        public int? InstructorId { get; set; }
        public byte? RowVersion { get; set; }
        public InstructorExists? Administrator { get; set; }
        public ICollection<Course>? Courses { get; set; }
    }
}