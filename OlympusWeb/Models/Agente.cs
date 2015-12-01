using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OlympusWeb.Models
{

    [Table("Agente")]
    public class Agente
    {

 
        public Agente()
        {
           this.Contrato = new HashSet<Contrato>();
        }
        public int AgenteId { get; set; }
        [Required]
        [Display(Name = "Codigo de Agente")]
        public string CodigoAgente { get; set; }
        public Nullable<Estado> Estado { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual ICollection<Contrato> Contrato { get; set; }
    }
}

