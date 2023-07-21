using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace Repository.Models
{
    public partial class PetShop2023DB_2Context : DbContext
    {
        public PetShop2023DB_2Context()
        {
        }

        public PetShop2023DB_2Context(DbContextOptions<PetShop2023DB_2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Pet> Pets { get; set; }
        public virtual DbSet<PetGroup> PetGroups { get; set; }
        public virtual DbSet<PetShopMember> PetShopMembers { get; set; }
        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:DefaultConnectionStringDB"];
            return strConn;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Pet>(entity =>
            {
                entity.ToTable("Pet");

                entity.Property(e => e.PetId).ValueGeneratedNever();

                entity.Property(e => e.ImportDate).HasColumnType("datetime");

                entity.Property(e => e.PetDescription).HasMaxLength(220);

                entity.Property(e => e.PetGroupId).HasMaxLength(20);

                entity.Property(e => e.PetName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.PetGroup)
                    .WithMany(p => p.Pets)
                    .HasForeignKey(d => d.PetGroupId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Pet__PetGroupId__3C69FB99");
            });

            modelBuilder.Entity<PetGroup>(entity =>
            {
                entity.ToTable("PetGroup");

                entity.Property(e => e.PetGroupId).HasMaxLength(20);

                entity.Property(e => e.GroupDescription).HasMaxLength(150);

                entity.Property(e => e.OriginalSource).HasMaxLength(60);

                entity.Property(e => e.PetGroupName)
                    .IsRequired()
                    .HasMaxLength(80);
            });

            modelBuilder.Entity<PetShopMember>(entity =>
            {
                entity.HasKey(e => e.MemberId)
                    .HasName("PK__PetShopM__0CF04B38BCA3C66F");

                entity.ToTable("PetShopMember");

                entity.HasIndex(e => e.EmailAddress, "UQ__PetShopM__49A1474025B2D3D2")
                    .IsUnique();

                entity.Property(e => e.MemberId)
                    .HasMaxLength(20)
                    .HasColumnName("MemberID");

                entity.Property(e => e.EmailAddress).HasMaxLength(100);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.MemberPassword)
                    .IsRequired()
                    .HasMaxLength(80);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
