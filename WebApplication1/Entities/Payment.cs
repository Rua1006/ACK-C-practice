﻿using System;
using System.Collections.Generic;

namespace WebApplication1.Entities;

public partial class Payment
{
    public ushort PaymentId { get; set; }

    public ushort CustomerId { get; set; }

    public byte StaffId { get; set; }

    public int? RentalId { get; set; }

    public decimal Amount { get; set; }

    public DateTime PaymentDate { get; set; }

    public DateTime? LastUpdate { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Rental? Rental { get; set; }

    public virtual Staff Staff { get; set; } = null!;
}
