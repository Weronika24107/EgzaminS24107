namespace EgzaminS24107.Models;

public class Musician_Track
{
    public int TrackId { get; set; }
    public Track Track { get; set; } = null!;

    public int MusicianId { get; set; }
    public Musician Musician { get; set; } = null!;

   
}
