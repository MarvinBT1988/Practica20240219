using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Practica20240219.Models;
public class Categoria
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    // Propiedad de Id como llave primaria autoincremental
    public int Id { get; set; }

    // Propiedad de Nombre obligatorio
    [Required(ErrorMessage = "El nombre de la categoría es obligatorio.")]
     [StringLength(100)]
    public string Nombre { get; set; }
}