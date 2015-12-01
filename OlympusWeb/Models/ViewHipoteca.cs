using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OlympusWeb.Models
{
    public class ViewHipoteca
    {
        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }

        [Required]
        [Display(Name = "Identificación")]
        public string Identificacion { get; set; }

        [Required]
        [Display(Name = "Correo Electrónico")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        [Required]
        [Display(Name = "Número de plano")]
        public string NumeroPlano { get; set; }

        [Required]
        [Display(Name = "Provincia")]
        public string Provincia { get; set; }

        [Required]
        [Display(Name = "Distrito")]
        public string Distrito { get; set; }

        [Required]
        [Display(Name = "Cantón")]
        public string Canton { get; set; }

        [Required]
        [Display(Name = "Gravamenes o Anotaciones")]
        public string GravamenesAnotaciones { get; set; }

        [Required]
        [Display(Name = "Tipo Propiedad")]
        public Nullable<TipoPropiedad> TipoPropiedad { get; set; }

        [Required]
        [Display(Name = "Fotos Propiedad")]
        public IEnumerable<HttpPostedFileBase> Fotos { get; set; }

        [Required]
        [Display(Name = "Plano Propiedad")]
        public HttpPostedFileBase Plano { get; set; }
    }
}


