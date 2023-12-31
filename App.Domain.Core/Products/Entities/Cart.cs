﻿using App.Domain.Core.Users.Entities;
using System;
using System.Collections.Generic;

namespace App.Domain.Core.Products.Entities;

public partial class Cart
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public int StatusId { get; set; }

    public virtual City? City { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<OrderLine> OrderLines { get; set; } = new List<OrderLine>();

    public virtual OrderStatus Status { get; set; } = null!;
}
