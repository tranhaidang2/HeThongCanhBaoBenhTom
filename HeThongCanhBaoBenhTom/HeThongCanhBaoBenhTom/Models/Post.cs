using System;
using System.Collections.Generic;

namespace HeThongCanhBaoBenhTom.Models;

public partial class Post
{
    public int PostId { get; set; }

    public string? PostTitle { get; set; }

    public string? PostContent { get; set; }

    public DateTime PostCreateAt { get; set; }

    public Guid UserId { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<Image> Images { get; set; } = new List<Image>();

    public virtual User? User { get; set; }
}
