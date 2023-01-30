using System;
using System.Collections.Generic;

namespace WebApplication1.Entities;

public partial class CustomerList
{
    public ushort Id { get; set; }

    public string? Name { get; set; }

    public string Address { get; set; } = null!;

    public string? ZipCode { get; set; }

    public string Phone { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public byte Sid { get; set; }
}
