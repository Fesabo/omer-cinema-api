using System;
using System.Collections.Generic;

namespace movieapi;

public partial class User
{
    public int Uid { get; set; }

    public string Fname { get; set; } = null!;

    public string Lname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;
}
