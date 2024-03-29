using System.ComponentModel.DataAnnotations;

namespace Inventario.Domain;

public class TblMaquina
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string NomeDaMaquina { get; set; }
    [Required]
    [MaxLength(20)]
    public string Modelo { get; set; }
    [Required]
    [MaxLength(15)]
    public string Processador {  get; set; }
    [Required]
    public int QuantidadeMemoriaRam {  get; set; }
    public DateTime DataCriacao { get; set; } = DateTime.Now;
}
