using System;
using System.Collections.Generic;

namespace 第2組期末專案.Models;

public partial class TCategory
{
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public string? CategoryCname { get; set; }

    public virtual ICollection<TSubCategory> TSubCategories { get; set; } = new List<TSubCategory>();
}
