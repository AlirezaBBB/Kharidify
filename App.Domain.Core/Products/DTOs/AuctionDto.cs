﻿using App.Domain.Core.Products.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Products.DTOs
{
    public class AuctionInputDto
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public DateTime EndDate { get; set; }

        public double? HighestPrice { get; set; }

        public bool IsActive { get; set; }

        public bool IsRemoved { get; set; }

        public int? LastBuyerId { get; set; }
    }

    public class AuctionOutputDto
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public double? HighestPrice { get; set; }

        public string? ImagePath { get; set; }

        public bool IsActive { get; set; }

        public bool IsRemoved { get; set; }

        public int? LastBuyerId { get; set; }

        public virtual Product Product { get; set; } = null!;
    }
}
