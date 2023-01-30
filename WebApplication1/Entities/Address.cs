using System;
using System.Collections.Generic;
using MySql.Data.Types;

namespace WebApplication1.Entities;

public partial class Address
{
    public ushort AddressId { get; set; }

    public string Address1 { get; set; } = null!;

    public string? Address2 { get; set; }

    public string District { get; set; } = null!;

    public ushort CityId { get; set; }

    public string? PostalCode { get; set; }

    public string Phone { get; set; } = null!;

    public MySqlGeometry Location { get; set; }

    public DateTime LastUpdate { get; set; }

    public virtual City City { get; set; } = null!;

    public virtual ICollection<Customer> Customers { get; } = new List<Customer>();

    public virtual ICollection<Staff> Staff { get; } = new List<Staff>();

    public virtual ICollection<Store> Stores { get; } = new List<Store>();
}
