using System;
using System.Collections.Generic;

namespace WebApplication1.Entities;

public partial class Language
{
    public int language_id { get; set; }

    public string Name { get; set; }

    public DateTime last_update { get; set; }

    public virtual ICollection<Film> FilmLanguages { get; } = new List<Film>();

    public virtual ICollection<Film> FilmOriginalLanguages { get; } = new List<Film>();
}
