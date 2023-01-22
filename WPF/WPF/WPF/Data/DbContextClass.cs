using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WPF.Model;
using WPF.Model.Labels;

public class DbContextClass : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer("Server=DIMA\\SQLEXPRESS;Database=prepod_db;Trusted_Connection=True;TrustServerCertificate=True;");
    }
    public DbSet<Note> Notes { get; set; }
    public DbSet<Label> Lables { get; set; }
}