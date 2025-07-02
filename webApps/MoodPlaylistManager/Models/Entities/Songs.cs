using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoodPlaylistManager.Models.Entities
{
    public class Songs
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;
        public string Artist { get; set; } = string.Empty;

        [ForeignKey("Playlists")]
        public Guid PlaylistId { get; set; }
        public Playlists Playlist { get; set; }
    }
}
