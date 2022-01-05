using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Food_Delivery_App_API.Entities
{
    public partial class OnlineFoodDeliveryContext : DbContext
    {
        public OnlineFoodDeliveryContext()
        {
        }

        public OnlineFoodDeliveryContext(DbContextOptions<OnlineFoodDeliveryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DeliveryAgent> DeliveryAgents { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-DHE93BQG\\SQLEXPRESS;Initial Catalog=OnlineFoodDelivery;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<DeliveryAgent>(entity =>
            {
                entity.HasKey(e => e.AgentId)
                    .HasName("PK__Delivery__9AC3BFF11E55B288");

                entity.Property(e => e.AgentName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AgentPhone)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.HasOne(d => d.Restaraunt)
                    .WithMany(p => p.DeliveryAgents)
                    .HasForeignKey(d => d.RestarauntId)
                    .HasConstraintName("FK__DeliveryA__Resta__3B75D760");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.Property(e => e.IsAvailable)
                    .IsRequired()
                    .HasColumnName("isAvailable")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ItemDescription)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.RestaurantId)
                    .HasConstraintName("FK__Items__Restauran__37A5467C");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasDefaultValueSql("((1))");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.AgentId)
                    .HasConstraintName("FK__Orders__AgentId__3F466844");

                entity.HasOne(d => d.Restaraunt)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.RestarauntId)
                    .HasConstraintName("FK__Orders__Restarau__3E52440B");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Orders__UserId__403A8C7D");
            });

            modelBuilder.Entity<Restaurant>(entity =>
            {
                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RestaurantAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RestaurantName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Restaurants)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Restauran__UserI__34C8D9D1");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.EmailId, "UQ__Users__7ED91ACEB1B6110C")
                    .IsUnique();

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
