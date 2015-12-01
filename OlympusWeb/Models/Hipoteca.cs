using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OlympusWeb.Models
{
    public enum TipoPropiedad
    {
       Finca=0,
       Casa=1,
       Lote=2,
       Otros=3
    }

    [Table("Hipoteca")]
    public class Hipoteca
    {
        public Hipoteca()
        {
            this.Contrato = new HashSet<Contrato>();
        }
        public int HipotecaId { get; set; }
        public string NumeroPlano { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public string Canton { get; set; }
        public string Monto { get; set; }
        public string GravamenesAnotaciones { get; set; }
        public Nullable<TipoPropiedad> TipoPropiedad { get; set; }
        public Nullable<Estado> Estado { get; set; }
        public virtual ICollection<Contrato> Contrato { get; set; }
        public virtual ICollection<FotosPropiedad> FotosPropiedad { get; set; }
        public virtual Persona Persona { get; set; }
    }
}