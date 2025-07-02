namespace MoodPlaylistManager.Models.DTOs
{
    public class UpdateSongsDto
    {
        public string Title { get; set; } = string.Empty;
        public string Artist { get; set; } = string.Empty;
        public Guid PlaylistId { get; set; }
        public Guid Id { get; set; }
    }
}
