﻿using System;
using System.Collections.Generic;

namespace MIS_Classroom.Models
{
    public partial class TechengineeMisTeacher
    {
        public int TeacherId { get; set; }
        public string? Name { get; set; }
        public string Email { get; set; } = null!;
        public int? SubjectCode { get; set; }

        // Navigation property
        public TechengineeMisSubject Subject { get; set; }
    }
}
