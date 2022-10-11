using System.ComponentModel.DataAnnotations;

namespace PruebaPart1.Models
{
    public class Persona_cliente
    {

        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "El Documento es obligatorio")]
        public String Documento { get; set; }

        [Required(ErrorMessage = "El primer nombre es obligatorio")]
        public string primerNombre { get; set; }

        public string segundoNombre { get; set; }

        [Required(ErrorMessage = "El primer apellido es obligatorio")]
        public string primerApellido { get; set; }

        public string segundoApellido { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }


        [Required(ErrorMessage = "La Dirección  es obligatoria")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "La Edad es obligatoria")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "El genero es obligatorio")]

        public string Genero{ get; set; }   
    }
}
