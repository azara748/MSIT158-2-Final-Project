﻿using System;
using System.Collections.Generic;

namespace 第2組期末專案.Models;

public partial class TPay
{
    public int PayId { get; set; }

    public int? OrderId { get; set; }

    public int? PayTypeId { get; set; }

    public decimal? Amount { get; set; }

    public virtual TPayType? PayType { get; set; }
}
