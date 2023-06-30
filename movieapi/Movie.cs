using System;
using System.Collections.Generic;

namespace movieapi;

public partial class Movie
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public int? Length { get; set; }

    public string? PosterLink { get; set; }

    public string? ReleaseYear { get; set; }
}
