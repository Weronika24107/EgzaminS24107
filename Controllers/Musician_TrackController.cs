using EgzaminS24107.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EgzaminS24107.Controllers;

[ApiController]
[Route("api/[controller]")]
public class Musician_TrackController : ControllerBase
{
    private readonly AppDbContext _db;
    public Musician_TrackController(AppDbContext db) => _db = db;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _db.Musician_Tracks
            .Include(e => e.Musician)
            .Include(e => e.Track)
            .Select(e => new
            {
                student = new
                {
                    id = e.Musician.Id,
                    firstName = e.Musician.FirstName,
                    lastName = e.Musician.LastName,
                    nickname = e.Musician.NickName
                },
                Track = new
                {
                    id = e.Track.Id,
                    name = e.Track.TrackName,
                    duration = e.Track.Duration
                },
                
            })
            .ToListAsync();

        return Ok(result);
    }
}
