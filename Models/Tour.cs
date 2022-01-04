namespace vacayBackend.Models
{
  public class Tour
  {
    public int Id { get; set; }
    public string City { get; set; }
    public int Duration { get; set; }
    public int Price { get; set; }
    public int CruiseId { get; set; }
    public int ResortId { get; set; }

  }

  public class TourViewModel : Tour
  {
    public Cruise Cruise { get; set; }
    public Resort Resort { get; set; }
  }
}