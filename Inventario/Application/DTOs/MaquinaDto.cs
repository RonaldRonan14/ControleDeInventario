namespace Inventario.Application.DTOs;

public class MaquinaDto
{
    public int Id { get; set; }
    public string NomeDaMaquina { get; set; }
    public string Modelo { get; set; }
    public string Processador { get; set; }
    public int QuantidadeMemoriaRam { get; set; }
}

public class CreateMaquinaDto
{
    public string NomeDaMaquina { get; set; }
    public string Modelo { get; set; }
    public string Processador { get; set; }
    public int QuantidadeMemoriaRam { get; set; }
}

public class UpdateMaquinaDto
{
    public string NomeDaMaquina { get; set; }
    public string Modelo { get; set; }
    public string Processador { get; set; }
    public int QuantidadeMemoriaRam { get; set; }
}