using EgzaminS24107.Models;

namespace EgzaminS24107.Models;

public class Album
{
    public int Id { get; set; }
    public string AlbumName { get; set; } = null!;
    public DateTime PublishDate { get; set; }

    public int MusicLabelId { get; set; }
    public MusicLabel MusicLabel { get; set; } = null!;

   


    public ICollection<Track> Tracks { get; set; } = new List<Track>();
}
