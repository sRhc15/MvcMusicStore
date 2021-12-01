using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcMusicStore.Models
{
    public class MusicStoreEntities :DbContext
    {
        /*public MusicStoreEntities(): base("MusicStoreEntities")
        { }*/
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Artist> Artists { get; set; }  //No se porque al agregar esta linea finalmente dejo crear el scaffolding 
    }

}

/*  Cosas que ya intente: 
    -Provider name anterior: System.Data.SqlServerCe.4.0
    -Clean y build al proyecto
    -Mover connectionStrings fuera de<entityFramework>
    -Repetir proyecto desde la creacion del MusicStoreEntities :(
    -Buscar otro provider name aparte de SqlServcerCe con el manager de NuGet y probar cada uno
    -Agregar en el modelo entities: "public DbSet<Artist> Artists { get; set; }"*/