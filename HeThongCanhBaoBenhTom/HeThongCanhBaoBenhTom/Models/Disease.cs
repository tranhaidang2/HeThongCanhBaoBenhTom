using System;
using System.Collections.Generic;

namespace HeThongCanhBaoBenhTom.Models;

public partial class Disease
{
    public int DiseaseId { get; set; }

    public string? DiseaseName { get; set; }

    public string? Description { get; set; }

    public string? Symptoms { get; set; }

    public string? Cause { get; set; }

    public Guid UserId { get; set; }

    public virtual ICollection<Image> Images { get; set; } = new List<Image>();

    public virtual ICollection<Prevention> Preventions { get; set; } = new List<Prevention>();

    public virtual User? User { get; set; }
}
