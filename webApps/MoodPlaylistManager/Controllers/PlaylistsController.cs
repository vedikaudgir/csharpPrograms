using Microsoft.AspNetCore.Mvc;
using MoodPlaylistManager.Data;
using MoodPlaylistManager.Models.Entities;
using MoodPlaylistManager.Models.DTOs;

namespace MoodPlaylistManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlaylistsController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public PlaylistsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllPlaylists()
        {
            return Ok(dbContext.Playlist.ToList());
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetPlaylistById(Guid id)
        {
            var playlist = dbContext.Playlist.Find(id);

            if (playlist == null)
                return NotFound();

            return Ok(playlist);
        }

        [HttpPost]
        public IActionResult CreatePlaylist(AddPlaylistsDto dto)
        {
            var playlist = new Playlists
            {
                PlaylistName = dto.PlaylistName,
                Mood = dto.Mood,
                Artist = dto.Artist
            };

            dbContext.Playlist.Add(playlist);
            dbContext.SaveChanges();

            return Ok(playlist);
        }

        [HttpPut("{id:guid}")]
        public IActionResult UpdatePlaylist(Guid id, UpdatePlaylistsDto dto)
        {
            var playlist = dbContext.Playlist.Find(id);

            if (playlist == null)
                return NotFound();

            playlist.PlaylistName = dto.PlaylistName;
            playlist.Mood = dto.Mood;
            playlist.Artist = dto.Artist;

            dbContext.SaveChanges();
            return Ok(playlist);
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeletePlaylist(Guid id)
        {
            var playlist = dbContext.Playlist.Find(id);

            if (playlist == null)
                return NotFound();

            dbContext.Playlist.Remove(playlist);
            dbContext.SaveChanges();

            return Ok(playlist);
        }
    }
}
