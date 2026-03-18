using Microsoft.EntityFrameworkCore;
using BackEnd.Models;

namespace BackEnd.Data
{
    public class Database : DbContext
    {
        public Database(DbContextOptions<Database> options) : base(options)
        {
        }

        // bảng Products
        public DbSet<Product> Products { get; set; }

        // bảng Users (để login sau này)
        public DbSet<User> Users { get; set; }
    }
}