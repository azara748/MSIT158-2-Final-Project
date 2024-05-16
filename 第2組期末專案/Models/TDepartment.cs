using System;
using System.Collections.Generic;

namespace 第2組期末專案.Models;

public partial class TDepartment
{
    public int DepId { get; set; }

    public string? DepName { get; set; }

    public virtual ICollection<TEmployee> TEmployees { get; set; } = new List<TEmployee>();
}
