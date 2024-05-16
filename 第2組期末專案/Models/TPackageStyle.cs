using System;
using System.Collections.Generic;

namespace 第2組期末專案.Models;

public partial class TPackageStyle
{
    public int PackageStyleId { get; set; }

    public string StyleName { get; set; } = null!;

    public string? Picture { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<TAllPackage> TAllPackages { get; set; } = new List<TAllPackage>();
}
