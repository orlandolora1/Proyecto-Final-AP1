
using System.ComponentModel.DataAnnotations;

public class TipoJugada
{
    [Key]
    public int TipoJugadaId { get; set; }
    public int LoteriaId { get; set; }
    
    public string NombreJugada { get; set; }
}