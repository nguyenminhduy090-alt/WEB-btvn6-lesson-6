using System.ComponentModel.DataAnnotations;

namespace BookManagementMVC.Models;

public class Book
{
    public int Id { get; set; }

    [Required]
    public string Title { get; set; } = "";

    public string Author { get; set; } = "";

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public string Category { get; set; } = "";
}