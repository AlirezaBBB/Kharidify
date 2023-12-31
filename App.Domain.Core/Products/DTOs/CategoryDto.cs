﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Products.DTOs
{
    public class CategoryOutputDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string ImageAddress { get; set; } = null!;
    }
}
