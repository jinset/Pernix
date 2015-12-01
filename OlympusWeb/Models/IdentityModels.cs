using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System;

namespace OlympusWeb.Models
{
    // Puede agregar datos del perfil del usuario agregando más propiedades a la clase ApplicationUser. Para más información, visite http://go.microsoft.com/fwlink/?LinkID=317594.
    public class ApplicationUser : IdentityUser
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Identificacion { get; set; }
        public string Telefono { get; set; }
        public int MontoInvertir { get; set; }
        public decimal TasaInteres { get; set; }
        public Nullable<Estado> Estado { get; set; }
        public virtual ICollection<Contrato> Contrato { get; set; }


        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Tenga en cuenta que el valor de authenticationType debe coincidir con el definido en CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Agregar reclamaciones de usuario personalizado aquí
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Contrato>().HasKey(e => new {e.ApplicationUserId, e.ContratoId });
        }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<OlympusWeb.Models.Persona> Persona { get; set; }
        public System.Data.Entity.DbSet<OlympusWeb.Models.Agente> Agente { get; set; }
        public System.Data.Entity.DbSet<OlympusWeb.Models.Hipoteca> Hipoteca { get; set; }
        public System.Data.Entity.DbSet<OlympusWeb.Models.AgenteIns> AgenteIns { get; set; }
        public System.Data.Entity.DbSet<OlympusWeb.Models.Abogado> Abogado { get; set; }
        public System.Data.Entity.DbSet<OlympusWeb.Models.Perito> Perito { get; set; }
        public System.Data.Entity.DbSet<OlympusWeb.Models.FotosPropiedad> FotosPropiedad { get; set; }

        public System.Data.Entity.DbSet<OlympusWeb.Models.Contrato> Contratoes { get; set; }

        public System.Data.Entity.DbSet<OlympusWeb.Models.ApplicationUser> ApplicationUsers { get; set; }
    }
}