using System;

namespace vacayBackend.Models
{
  public class Cruise
  {
    public int Id { get; set; }
    public string Destination { get; set; }
    public int Tours { get; set; }
    public DateTime StartDate { get; set; }
    public double Price { get; set; }
  }
}