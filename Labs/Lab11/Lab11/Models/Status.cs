﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11.Models
{
    public class Status
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Book>? Books { get; set; }
    }
}
