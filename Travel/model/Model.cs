namespace Travel.model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=TModel")
        {
        }

        public virtual DbSet<Famous_Place> Famous_Place { get; set; }
        public virtual DbSet<Food_Bev> Food_Bev { get; set; }
        public virtual DbSet<Hospital_Clinic> Hospital_Clinic { get; set; }
        public virtual DbSet<Hotel> Hotels { get; set; }
        public virtual DbSet<Souvenir_Shop> Souvenir_Shop { get; set; }
        public virtual DbSet<tbVPimg> tbVPimgs { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<Visit_Place> Visit_Place { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Famous_Place>()
                .Property(e => e.Famous_Place_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Famous_Place>()
                .Property(e => e.Visit_Place_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Food_Bev>()
                .Property(e => e.Food_Bev_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Food_Bev>()
                .Property(e => e.Visit_Place_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Hospital_Clinic>()
                .Property(e => e.Hospital_Clinic_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Hospital_Clinic>()
                .Property(e => e.Visit_Place_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.Hotel_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.Visit_Place_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Souvenir_Shop>()
                .Property(e => e.Souvenir_Shop_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Souvenir_Shop>()
                .Property(e => e.Visit_Place_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tbVPimg>()
                .Property(e => e.Visit_Place_Image_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tbVPimg>()
                .Property(e => e.Visit_Place_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Vehicle_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Visit_Place_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Visit_Place>()
                .Property(e => e.Visit_Place_ID)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
