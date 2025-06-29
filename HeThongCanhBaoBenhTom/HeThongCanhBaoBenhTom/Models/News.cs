﻿using System;
using System.Collections.Generic;

namespace HeThongCanhBaoBenhTom.Models;

public partial class News
{
    public int NewsId { get; set; }

    public string? NewsTitle { get; set; }

    public string? NewsShortDescription { get; set; }

    public string? NewsContent { get; set; }

    public DateTime NewsCreateAt { get; set; }

    public Guid UserId { get; set; }

    public virtual ICollection<Image> Images { get; set; } = new List<Image>();

    public virtual User? User { get; set; }
}
