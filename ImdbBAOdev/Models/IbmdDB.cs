namespace ImdbBAOdev.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class IbmdDB : DbContext
    {
        public IbmdDB()
            : base("name=IbmdDB")
        {
        }
        public virtual DbSet<Aktor> Aktor { get; set; }
        public virtual DbSet<Film> Film { get; set; }
        public virtual DbSet<FilmTuru> FilmTuru { get; set; }
        public virtual DbSet<Yonetmen> Yonetmen { get; set; }
    }
}