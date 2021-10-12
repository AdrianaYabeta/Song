using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSong.Models
{
    public class Song
    {
        [Key]
        [Required(ErrorMessage = "El nombre de la cancion es requerido")]
        [StringLength(80, MinimumLength = 5, ErrorMessage = "El nombre de la cancion debe tener entre 5 a 80 caracteres")]
        [Display(Name = "Nombre de la cancion")]
        public string Cancion { get; set; }
        [Required]
        [StringLength(100, MinimumLength =2, ErrorMessage = "El nombre del autor debe tener entre 2 a 100 caracteres")]
        [Display(Name = "Nombre del autor")]
        public string Autor { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "La letra de la cancion debe tener entre 2 a 100 caracteres")]
        [Display(Name = "Letra")]
        public string Letra { get; set; }
        [Url]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "La longitd del enlace debe tener entre 2 a 100 caracteres")]
        [Display(Name = "Enlaces")]
        public string Enlace { get; set; }

    }
}
