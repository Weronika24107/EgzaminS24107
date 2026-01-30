using EgzaminS24107.Models;

namespace EgzaminS24107.Models;

public class Track
{
    public int Id { get; set; }
    public string TrackName { get; set; } = null!;
    public string Duration { get; set; } = null!;
    public int AlbumId { get; set; }
    public Album Album { get; set; } = null!;

    public ICollection<Musician_Track> Musician_Tracks { get; set; } = new List<Musician_Track>();
}
