using Microsoft.EntityFrameworkCore;

using msg_board.Models;

namespace msg_board.Data
{
  public class DBContext : DbContext
  {
    /// <summary>
    /// DBSet of Locations
    /// </summary>
    /// <value></value>
    public DbSet<Message> Messages { get; set; }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {

    }
  }
}