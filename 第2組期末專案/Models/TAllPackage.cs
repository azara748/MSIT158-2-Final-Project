using System;
using System.Collections.Generic;

namespace 第2組期末專案.Models;

public partial class TAllPackage
{
    public int PackageId { get; set; }

    public string? PackName { get; set; }

    public decimal? Price { get; set; }

    public string? Picture { get; set; }

    public int? PackageStyleId { get; set; }

    public int? TypeId { get; set; }

    public int? MaterialId { get; set; }

    public string? Description { get; set; }

    public string? Size { get; set; }

    public virtual TPackageMaterial? Material { get; set; }

    public virtual TPackageStyle? PackageStyle { get; set; }

    public virtual ICollection<TPackageWayDetail> TPackageWayDetails { get; set; } = new List<TPackageWayDetail>();
}
