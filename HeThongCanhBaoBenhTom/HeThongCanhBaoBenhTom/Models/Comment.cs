using System;
using System.Collections.Generic;

namespace HeThongCanhBaoBenhTom.Models;

public partial class Comment
{
    public int CommentId { get; set; }

    public string? CommentContent { get; set; }

    public DateTime CommentCreateAt { get; set; }

    public int? PostId { get; set; }

    public Guid UserId { get; set; }

    public virtual Post? Post { get; set; }

    public virtual User? User { get; set; }
}
