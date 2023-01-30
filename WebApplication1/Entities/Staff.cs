﻿using System;
using System.Collections.Generic;

namespace WebApplication1.Entities;

public partial class Staff
{
    public byte StaffId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public ushort AddressId { get; set; }

    public byte[]? Picture { get; set; }

    public string? Email { get; set; }

    public byte StoreId { get; set; }

    public bool? Active { get; set; }

    public string Username { get; set; } = null!;

    public string? Password { get; set; }

    public DateTime LastUpdate { get; set; }

    public virtual Address Address { get; set; } = null!;

    public virtual ICollection<Payment> Payments { get; } = new List<Payment>();

    public virtual ICollection<Rental> Rentals { get; } = new List<Rental>();

    public virtual Store Store { get; set; } = null!;

    public virtual Store? StoreNavigation { get; set; }
}
