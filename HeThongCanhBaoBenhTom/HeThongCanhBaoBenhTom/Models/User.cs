using System;
using System.Collections.Generic;

namespace HeThongCanhBaoBenhTom.Models;

public partial class User
{
    public Guid UserId { get; set; }

    public string Username { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Fullname { get; set; }

    public DateTime CreatedAt { get; set; }

    public int RoleId { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<Disease> Diseases { get; set; } = new List<Disease>();

    public virtual ICollection<News> News { get; set; } = new List<News>();

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();

    public virtual Role Role { get; set; } = null!;
}
