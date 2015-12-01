using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OlympusWeb.Models
{
    [Table("FotosPropiedad")]
    public class FotosPropiedad
    {
        public int FotosPropiedadId { get; set; }
        public string FileName { get; set; }
        public int Tipo { get; set; }
        public byte[] File { get; set; }
        public virtual Hipoteca hipoteca { get; set; }

    }
}