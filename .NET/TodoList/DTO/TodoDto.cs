using System.ComponentModel.DataAnnotations;
namespace TodoList.DTO;

public class TodoDto
{
    [Required]
    [StringLength(100)]
    public string? Task { get; set; }
}