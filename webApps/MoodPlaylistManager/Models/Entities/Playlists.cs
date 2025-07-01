namespace MoodPlaylistManager.Models.Entities
{
    public class Playlists
    {
        public Guid Id { get; set; }
        public string songName { get; set; } = string.Empty;
        public string Mood { get; set; } = string.Empty;
        public string Artist { get; set; } = string.Empty;
        public DateTime createdAt { get; set; } = DateTime.UtcNow;
    }
}
