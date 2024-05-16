using System;
using System.Collections.Generic;

namespace 第2組期末專案.Models;

public partial class TKeyword
{
    public int? ProductId { get; set; }

    public int TagId { get; set; }

    public string? Festival { get; set; }

    public string? Topic { get; set; }

    public string? Color { get; set; }

    public string Tag { get; set; } = null!;

    public virtual TProduct? Product { get; set; }
}
