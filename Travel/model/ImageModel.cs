namespace Travel.model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ImageModel : DbContext
    {
        public ImageModel()
            : base("name=ImageModel")
        {
        }

        public virtual DbSet<tbFBimg> tbFBimg { get; set; }
        public virtual DbSet<tbFPimg> tbFPimg { get; set; }
        public virtual DbSet<tbHCimg> tbHCimg { get; set; }
        public virtual DbSet<tbHotelimg> tbHotelimg { get; set; }
        public virtual DbSet<tbSSimg> tbSSimg { get; set; }
        public virtual DbSet<tbVimg> tbVimg { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbFBimg>()
                .Property(e => e.Food_Bev_Image_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tbFBimg>()
                .Property(e => e.Visit_Place_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tbFPimg>()
                .Property(e => e.Famous_Place_Image_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tbFPimg>()
                .Property(e => e.Visit_Place_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tbHCimg>()
                .Property(e => e.Hospital_Clinic_Image_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tbHCimg>()
                .Property(e => e.Visit_Place_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tbHotelimg>()
                .Property(e => e.Hotel_Image_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tbHotelimg>()
                .Property(e => e.Visit_Place_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tbSSimg>()
                .Property(e => e.Souvenir_Shop_Image_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tbSSimg>()
                .Property(e => e.Visit_Place_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tbVimg>()
                .Property(e => e.Vehicle_Image_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tbVimg>()
                .Property(e => e.Visit_Place_ID)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
