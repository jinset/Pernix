using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OlympusWeb.Models
{
    [Table("Contrato")]
    public class Contrato
    {
        public int ContratoId { get; set; }
        public Agente Agente { get; set; }
        public Hipoteca Hipoteca { get; set; }
        public AgenteIns AgenteIns { get; set; }
        public Perito Perito { get; set; }
        public Abogado Abogado { get; set; }
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser AplicationUsers { get; set; }

    }
}