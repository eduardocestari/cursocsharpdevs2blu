using Devs2Blu.ProjetosAula.MVCSQLServer.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Devs2Blu.ProjetosAula.MVCSQLServer.Models
{
    public class Contexto : DbContext
    {
                public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {

        }

        #region DbSets

        public DbSet<Filme> Filme { get; set; }

        #endregion

    }
}
