using System;
using System.Collections.Generic;

namespace 第2組期末專案.Models;

public partial class TAppraisal
{
    public int RankId { get; set; }

    public string? Rank { get; set; }

    public virtual ICollection<TReview> TReviews { get; set; } = new List<TReview>();
}
