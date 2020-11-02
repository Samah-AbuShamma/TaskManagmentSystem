﻿using System;
using System.Collections.Generic;

namespace TaskManagmentSystem.Models
{
    public partial class TasksCategories
    {
        public int? CategoryId { get; set; }
        public int? TaskId { get; set; }

        public virtual Categories Category { get; set; }
        public virtual Tasks Task { get; set; }
    }
}
