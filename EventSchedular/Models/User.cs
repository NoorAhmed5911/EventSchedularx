﻿using System;
using System.Collections.Generic;

namespace Event_Schedular.Models;

public partial class User
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Role { get; set; }
}
