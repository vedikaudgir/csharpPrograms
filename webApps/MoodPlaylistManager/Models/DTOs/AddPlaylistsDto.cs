namespace MoodPlaylistManager.Models.DTOs
{
    public class AddPlaylistsDto
    {
        public string PlaylistName { get; set; } = string.Empty;
        public string Mood { get; set; } = string.Empty;
        public string Artist { get; set; } = string.Empty;
    }
}
