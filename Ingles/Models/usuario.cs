using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Ingles.Models
{
    public class usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string apellido_p { get; set; }
        [Required]
        public string apellido_m { get; set; }
        [Required]
        public int matricula { get; set; }
        [Required]
        public string contraseña { get; set; }
        [Required]
        public string nivel { get; set; }
    }
}