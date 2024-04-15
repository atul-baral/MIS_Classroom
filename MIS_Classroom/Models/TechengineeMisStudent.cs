﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MIS_Classroom.Models
{
    public partial class TechengineeMisStudent
    {
        public int StudentId { get; set; }
        public string? Name { get; set; }
        public string Email { get; set; } = null!;
        public int? Semester { get; set; }
    }
}
