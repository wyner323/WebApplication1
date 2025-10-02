using System.ComponentModel.DataAnnotations;

public class Visita
{
    [Required]
    public string RAAluno { get; set; }

    [Required]
    public DateTime DataVisita { get; set; }

    [Required]
    public int NumeroProjeto { get; set; }

    [Required]
    [Range(0, 5)]
    public int Nota { get; set; }
}
