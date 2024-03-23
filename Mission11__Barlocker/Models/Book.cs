using System.ComponentModel.DataAnnotations;

namespace Mission11__Barlocker.Models;

public class Book
{
    [Key]
    public required int BookID { get; set; }
    public required string Title { get; set; }
    public required string Author { get; set; }
    public required string Publisher { get; set; }
    public required string ISBN { get; set; }
    public required string Classification { get; set; }
    public required string Category { get; set; }
    public required int PageCount { get; set; }
    public required double Price { get; set; }
}