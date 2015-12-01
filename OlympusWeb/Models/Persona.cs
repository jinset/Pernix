using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OlympusWeb.Models
{
    [Table("Persona")]
    public class Persona
    {
        public Persona()
        {
            this.Agente = new HashSet<Agente>();
            this.AgenteIns = new HashSet<AgenteIns>();
            this.Hipoteca = new HashSet<Hipoteca>();
            this.Abogado = new HashSet<Abogado>();
            this.Perito = new HashSet<Perito>();
        }
        public int PersonaId { get; set; }
        [Required]
        [Display(Name = "Nombre", ResourceType = typeof(Resources.FormPersona))]
        public string Nombre { get; set; }
        [Required]
        [Display(Name = "Apellido", ResourceType = typeof(Resources.FormPersona))]
        public string Apellido { get; set; }
        [Required]
        [Display(Name = "Identificacion", ResourceType = typeof(Resources.FormPersona))]
        public string Identificacion { get; set; }
        [Required]
        [Display(Name = "Telefono", ResourceType = typeof(Resources.FormPersona))]
        public string Telefono { get; set; }
        [Required]
        [Display(Name = "Email", ResourceType = typeof(Resources.FormPersona))]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public virtual ICollection<Agente> Agente { get; set; }
        public virtual ICollection<AgenteIns> AgenteIns { get; set; }
        public virtual ICollection<Hipoteca> Hipoteca { get; set; }
        public virtual ICollection<Abogado> Abogado { get; set; }
        public virtual ICollection<Perito> Perito { get; set; }
    }



}