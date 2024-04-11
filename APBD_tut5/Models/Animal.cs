namespace APBD_tut5.Models;

public class Animal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public int Weight { get; set; }
    public int FurColor { get; set; }
    public List<Visit> visits { get; set; }
}