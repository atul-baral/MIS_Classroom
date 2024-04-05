﻿using System.Collections.Generic;
using MIS_Classroom.Models;

namespace MIS_Classroom.Areas.Admin.Models
{
    public class AdminDashboardViewModel
    {
        public List<TechengineeMisTeacher> TechengineeMisTeachers { get; set; }
        public List<TechengineeMisStudent> TechengineeMisStudents { get; set; }
    }
}
