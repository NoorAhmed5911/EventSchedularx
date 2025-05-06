using System;
using System.Collections.Generic;

namespace Event_Schedular.Models;

public partial class Event
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public DateTime? Date { get; set; }

    public string? Category { get; set; }

    public int? UserId { get; set; }
}
