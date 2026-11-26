using System.ComponentModel.DataAnnotations;

namespace PaginaTec.Models;

public class Opinion
{

    [Required(ErrorMessage = "El nombre es obligatorio")]
    public string Nombre { get; set; } = string.Empty;


    [Required(ErrorMessage = "El apellido es obligatorio")]
    public string Apellido { get; set; } = string.Empty;


    [EmailAddress(ErrorMessage = "El correo no es válido")]
    public string Correo { get; set; } = string.Empty;


    [Required(ErrorMessage = "El mensaje es obligatorio")]
    public string Mensaje { get; set; } = string.Empty;
}