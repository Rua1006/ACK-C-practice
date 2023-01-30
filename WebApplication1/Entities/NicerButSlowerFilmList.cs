using System;
using System.Collections.Generic;

namespace WebApplication1.Entities;

public partial class NicerButSlowerFilmList
{
    public ushort? Fid { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string Category { get; set; } = null!;

    public decimal? Price { get; set; }

    public ushort? Length { get; set; }

    public string? Rating { get; set; }

    public string? Actors { get; set; }
}
