using System;
using System.Collections.Generic;

namespace WebApplication1.Entities;

public partial class Language : BaseEntity
{
    public int language_id { get; set; }

    public string? Name { get; set; }

}
