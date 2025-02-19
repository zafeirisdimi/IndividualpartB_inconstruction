﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Prototype.Models
{
    public class Student : IPerson
    {

        //[StringLength(50, MinimumLength = 5, ErrorMessage = "Validation Error in Student:FirstName")]
        //[StringLength(70, MinimumLength = 5, ErrorMessage = "Validation Error in Student:LastName")]
        //[StringLength(100, MinimumLength = 15, ErrorMessage = "Validation Error in Student:Email")]
        //[StringLength(20, MinimumLength = 10, ErrorMessage = "Validation Error in Student:Phone")]
        [Key]
        public int StudentId { get; set; }

        [Required]
        
        public string FirstName { get; set; }

        [Required]
        
        public string LastName { get; set; }

        [Required]
        
        public string Email { get; set; }

        [Required]
        
        public string Phone { get; set; }

        [Required]
        public decimal TuitionFees { get; set; }

        [Range(15, 100)]
        public int Age { get; set; }

        [ForeignKey("Grade")]
        public int? GradeId { get; set; }// foreign key --- relationship [0.1 to *]
        public Grade Grade { get; set; }

        [ForeignKey("City")]
        public int? CityId { get; set; } //foreign key --- relationship [0.1 to *]
        public City City { get; set; }

        

       
        public virtual ICollection<Course> Courses { get; set; } //navigation property
        public virtual ICollection<Trainer> Trainers { get; set; } //navigation property

        public virtual ICollection<Assignment> Assignments{ get; set; } //navigation property


        public Student()
        {
            this.Courses = new HashSet<Course>(); //implementation relationship many to many
            this.Trainers = new HashSet<Trainer>(); //implementation relationship many to many
            this.Assignments = new HashSet<Assignment>(); //implementation relationship many to many
        }

    }
}
