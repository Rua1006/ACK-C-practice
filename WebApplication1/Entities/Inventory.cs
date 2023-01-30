using System;
using System.Collections.Generic;

namespace WebApplication1.Entities;

public partial class Inventory
{
    public uint InventoryId { get; set; }

    public ushort FilmId { get; set; }

    public byte StoreId { get; set; }

    public DateTime LastUpdate { get; set; }

    public virtual Film Film { get; set; } = null!;

    public virtual ICollection<Rental> Rentals { get; } = new List<Rental>();

    public virtual Store Store { get; set; } = null!;
}
