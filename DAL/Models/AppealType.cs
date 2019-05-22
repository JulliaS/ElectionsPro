﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vybory.Models
{
    public class AppealType
    {
        [Key]
        public int Id { get; set; }

        public string Type { get; set; }

        public List<Appeal> Appeals { get; set; }
    }
}