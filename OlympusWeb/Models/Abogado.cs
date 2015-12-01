using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OlympusWeb.Models
{
    public enum Estado
    {
        Aceptado = 0,
        Pendiente = 1,
        Cancelado = 2
        
    }

    [Table("Abogado")]
    public class Abogado
    {
        public Abogado()
        {
            this.Contrato = new HashSet<Contrato>();
        }

        public int AbogadoId { get; set; }
        public Nullable<Estado> Estado { get; set; }
        public virtual Persona Persona { get; set; }
       
        public virtual ICollection<Contrato> Contrato { get; set; }
        
    }
}