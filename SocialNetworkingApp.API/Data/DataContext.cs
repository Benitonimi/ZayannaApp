using Microsoft.EntityFrameworkCore;
using SocialNetworkingApp.API.Models;

namespace SocialNetworkingApp.API.Data
{
    public class DataContext : DbContext
    {
            public DataContext(DbContextOptions<DataContext> options) : base (options)
            {}

            public DbSet<Value> Values { get; set; }
        
    }
}