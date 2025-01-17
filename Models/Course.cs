﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hackathon.Models
{
    public partial class Course
    {
        public Course()
        {
            Lectures = new HashSet<Lecture>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid CourseId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Lecture> Lectures { get; set; }
    }
}
