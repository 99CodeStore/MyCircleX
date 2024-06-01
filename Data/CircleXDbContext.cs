namespace Blogosphere.Data;

using Blogosphere.Models;
using Microsoft.EntityFrameworkCore;

public class CircleXDbContext : DbContext
{
    public DbSet<Post> Posts { get; set; }
    public DbSet<Comment> Comments { get; set; }

    public CircleXDbContext(DbContextOptions<CircleXDbContext> options) : base(options)
    {
    }
}