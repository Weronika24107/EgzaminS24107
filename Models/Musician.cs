using EgzaminS24107.Models;

namespace EgzaminS24107.Models;

public class Musician
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string NickName { get; set; } = null!;

    public ICollection<Musician_Track> Musician_Tracks { get; set; } = new List<Musician_Track>();
}
