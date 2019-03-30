using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HHRR.Models
{
    public class Datos
    {
       [Required]
        public string Cedula { get; set; }
       [Required]
       public string Nombre { get; set; }
       [Required]
       public string Apellido { get; set; }
       [Range (15, 100)]
        public int Edad { get; set; }
       [Phone]
       public string Telefono { get; set; }
       [EmailAddress]
       public string Correo { get; set; }
       public Genero Genero { get; set; }
       public string EstadoCivil { get; set; }
       public List<Controlador> Hobby { get; set; }

   
    }
}

public enum Genero
{
    Masculino,
    Femenino
}