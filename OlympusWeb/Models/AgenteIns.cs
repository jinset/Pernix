using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OlympusWeb.Models
{
    [Table("AgenteIns")]
    public class AgenteIns
    {
        public AgenteIns()
        {
            this.Contrato = new HashSet<Contrato>();
        }
        public int AgenteInsId { get; set; }
        public Nullable<Estado> Estado { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual ICollection<Contrato> Contrato { get; set; }
    }
}