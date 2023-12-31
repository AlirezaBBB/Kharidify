﻿using System;
using System.Collections.Generic;

namespace App.Domain.Core.Products.Entities;

public partial class Image
{
    public int Id { get; set; }

    public string Address { get; set; } = null!;

    public bool IsRemoved { get; set; }

    public int ProductsId { get; set; }

    public virtual Product Products { get; set; } = null!;
}
