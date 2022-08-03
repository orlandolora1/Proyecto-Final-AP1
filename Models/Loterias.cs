
using System.ComponentModel.DataAnnotations;

public class Loterias
{
    [Key]
    public int LoteriaId { get; set; }

    [Required(ErrorMessage = "Selecionar una loteria")]
    public string Nombre { get; set; }

}