using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class User
{
    public long UserId { get; set; }

    public string? UserLogin { get; set; }

    public string? UserPassword { get; set; }

    public string? UserEmail { get; set; }

    public virtual ICollection<AiModel>? AiModels { get; set; } = new List<AiModel>();
}
