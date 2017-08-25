using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmParaUm
{
    public class Contexto
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entidades.Cliente>()
                .HasKey(x => x.TodoID)
                .HasRequired(x => x.ObjTodo)
                .WithRequiredDependent(p => p.ObjParte);
        }
    }
}
