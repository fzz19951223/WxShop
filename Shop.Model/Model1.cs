namespace Shop.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=WxShop")
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<areas> areas { get; set; }
        public virtual DbSet<Back> Back { get; set; }
        public virtual DbSet<Banner> Banner { get; set; }
        public virtual DbSet<cities> cities { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Favorite> Favorite { get; set; }
        public virtual DbSet<GuiGe> GuiGe { get; set; }
        public virtual DbSet<Notice> Notice { get; set; }
        public virtual DbSet<OrderBillChi> OrderBillChi { get; set; }
        public virtual DbSet<OrderBillFat> OrderBillFat { get; set; }
        public virtual DbSet<ProductInfo> ProductInfo { get; set; }
        public virtual DbSet<ProductReview> ProductReview { get; set; }
        public virtual DbSet<ProductSort> ProductSort { get; set; }
        public virtual DbSet<ProductSortm> ProductSortm { get; set; }
        public virtual DbSet<provinces> provinces { get; set; }
        public virtual DbSet<ReviewImage> ReviewImage { get; set; }
        public virtual DbSet<SearchHistory> SearchHistory { get; set; }
        public virtual DbSet<ShopCart> ShopCart { get; set; }
        public virtual DbSet<Stock> Stock { get; set; }
        public virtual DbSet<SystemConfig> SystemConfig { get; set; }
        public virtual DbSet<Type> Type { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<areas>()
                .Property(e => e.areaid)
                .IsUnicode(false);

            modelBuilder.Entity<areas>()
                .Property(e => e.area)
                .IsUnicode(false);

            modelBuilder.Entity<areas>()
                .Property(e => e.cityid)
                .IsUnicode(false);

            modelBuilder.Entity<Back>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<Back>()
                .Property(e => e.Tel)
                .IsFixedLength();

            modelBuilder.Entity<cities>()
                .Property(e => e.cityid)
                .IsUnicode(false);

            modelBuilder.Entity<cities>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<cities>()
                .Property(e => e.provinceid)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.OrderBillFat)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Notice>()
                .Property(e => e.Text)
                .IsUnicode(false);

            modelBuilder.Entity<OrderBillChi>()
                .Property(e => e.Num)
                .IsFixedLength();

            modelBuilder.Entity<OrderBillFat>()
                .Property(e => e.Status)
                .IsFixedLength();

            modelBuilder.Entity<OrderBillFat>()
                .HasMany(e => e.OrderBillChi)
                .WithOptional(e => e.OrderBillFat)
                .HasForeignKey(e => e.FID);

            modelBuilder.Entity<ProductInfo>()
                .Property(e => e.Describe)
                .IsUnicode(false);

            modelBuilder.Entity<ProductInfo>()
                .Property(e => e.Text)
                .IsUnicode(false);

            modelBuilder.Entity<ProductInfo>()
                .HasMany(e => e.Favorite)
                .WithOptional(e => e.ProductInfo)
                .HasForeignKey(e => e.PID);

            modelBuilder.Entity<ProductInfo>()
                .HasMany(e => e.OrderBillChi)
                .WithOptional(e => e.ProductInfo)
                .HasForeignKey(e => e.PID);

            modelBuilder.Entity<ProductInfo>()
                .HasMany(e => e.ProductReview)
                .WithOptional(e => e.ProductInfo)
                .HasForeignKey(e => e.PID);

            modelBuilder.Entity<ProductInfo>()
                .HasMany(e => e.ShopCart)
                .WithRequired(e => e.ProductInfo)
                .HasForeignKey(e => e.PID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductInfo>()
                .HasMany(e => e.Stock)
                .WithRequired(e => e.ProductInfo)
                .HasForeignKey(e => e.PID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductReview>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<ProductSort>()
                .HasMany(e => e.ProductSortm)
                .WithRequired(e => e.ProductSort)
                .HasForeignKey(e => e.FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductSortm>()
                .HasMany(e => e.ProductInfo)
                .WithOptional(e => e.ProductSortm)
                .HasForeignKey(e => e.ProductSortId);

            modelBuilder.Entity<provinces>()
                .Property(e => e.provinceid)
                .IsUnicode(false);

            modelBuilder.Entity<provinces>()
                .Property(e => e.province)
                .IsUnicode(false);

            modelBuilder.Entity<SearchHistory>()
                .Property(e => e.Content)
                .IsUnicode(false);
        }
    }
}
