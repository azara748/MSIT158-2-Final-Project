using System;
using System.Collections.Generic;

namespace 第2組期末專案.Models;

public partial class TCart
{
    public int CartId { get; set; }

    public int? MemberId { get; set; }

    public int? ProductId { get; set; }

    public int? Qty { get; set; }

    public bool? Checking { get; set; }

    public decimal? UnitPrice { get; set; }

    public virtual TMember? Member { get; set; }

    public virtual TProduct? Product { get; set; }
}
