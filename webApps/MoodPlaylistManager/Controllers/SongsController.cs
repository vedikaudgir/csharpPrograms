using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoodPlaylistManager.Data;
using MoodPlaylistManager.Models.DTOs;
using MoodPlaylistManager.Models.Entities;

namespace MoodPlaylistManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public SongsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetAllSongs()
        {
            var songs = dbContext.Songs.ToList();
            return Ok(songs);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetSongById(Guid id)
        {
            var song = dbContext.Songs.Find(id);
            if (song == null)
                return NotFound();
            return Ok(song);
        }

        [HttpPost]
        public IActionResult AddSong(AddSongsDto dto)
        {
            var song = new Songs
            {
                Title = dto.Title,
                Artist = dto.Artist,
                PlaylistId = dto.PlaylistId
            };
            dbContext.Songs.Add(song);
            dbContext.SaveChanges();
            return Ok(song);
        }
        [HttpPut("{id:guid}")]
        public IActionResult UpdateSong(Guid id, AddSongsDto dto)
        {
            var song = dbContext.Songs.Find(id);
            if (song == null)
                return NotFound();
            song.Title = dto.Title;
            song.Artist = dto.Artist;
            song.PlaylistId = dto.PlaylistId;
            dbContext.SaveChanges();
            return Ok(song);
        }
        [HttpDelete("{id:guid}")]
        public IActionResult DeleteSong(Guid id)
        {
            var song = dbContext.Songs.Find(id);
            if (song == null)
                return NotFound();
            dbContext.Songs.Remove(song);
            dbContext.SaveChanges();
            return Ok(song);
        }
    }
}
