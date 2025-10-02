using System.ComponentModel.DataAnnotations;

public class Projeto
{
    [Required]
    [StringLength(50, MinimumLength = 3)]
    public required string Nome { get; set; }

    [Required]
    [EmailAddress]
    public required string Email { get; set; }

    [Required]
    [Range(1, 8)]
    public required string Turma { get; set; }

    [Required]
    [StringLength(500)]
    public required string Descricao { get; set; }

    [Required]
    [Range(10, 99)]
    public required string NumeroProjeto { get; set; }
}