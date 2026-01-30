using EgzaminS24107.Models;
using Microsoft.EntityFrameworkCore;

namespace EgzaminS24107.Data;

public class AppDbContext : DbContext
{
    public DbSet<Musician> Musicians => Set<Musician>();
    public DbSet<Track> Tracks => Set<Track>();
    public DbSet<Musician_Track> Musician_Tracks => Set<Musician_Track>();
    public DbSet<Album> Albums => Set<Album>();
    public DbSet<MusicLabel> MusicLabels => Set<MusicLabel>();
    


    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Musician_Track>()
            .HasKey(e => new { e.MusicianId, e.TrackId });

        modelBuilder.Entity<Musician_Track>()
            .HasOne(e => e.Musician)
            .WithMany(s => s.Musician_Tracks)
            .HasForeignKey(e => e.MusicianId);

        modelBuilder.Entity<Musician_Track>()
            .HasOne(e => e.Track)
            .WithMany(c => c.Musician_Tracks)
            .HasForeignKey(e => e.TrackId);

        // Unikalność “tego samego Musiciana”
        modelBuilder.Entity<Musician>()
            .HasIndex(s => new { s.FirstName, s.LastName, s.NickName })
            .IsUnique();
    }
}
