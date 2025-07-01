using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using MoodPlaylistManager.Models.Entities;

namespace MoodPlaylistManager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}        
        public DbSet<Playlists> Playlist { get; set; }
    }
}
