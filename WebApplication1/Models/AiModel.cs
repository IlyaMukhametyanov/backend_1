using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class AiModel
{
    public long AiModelId { get; set; }

    public long? AiModelAuthor { get; set; }

    public string? AiModelName { get; set; }

    public string? AiModelDescription { get; set; }

    public virtual User? AiModelAuthorNavigation { get; set; }
}
