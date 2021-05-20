using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Library.Models;

#nullable disable

namespace Library.Data
{
    public partial class LibraryContext : DbContext
    {
        public LibraryContext()
        {
        }

        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<IssuedBook> IssuedBooks { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Reader> Readers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseSqlite("Data Source = C:\\Users\\chikwork\\Desktop\\АЛЛА\\проектБД\\Library.db");
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\mssqllocaldb; Database=Dblybrary; Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.BookId)
                    .HasColumnType("INT")
                    .ValueGeneratedNever()
                    .HasColumnName("BookID");

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasColumnType("NVARCHAR");

                entity.Property(e => e.BookTitle)
                    .IsRequired()
                    .HasColumnType("NVARCHAR");

                entity.Property(e => e.GenId)
                    .HasColumnType("INT")
                    .HasColumnName("GenID");

                entity.Property(e => e.PubId)
                    .HasColumnType("INT")
                    .HasColumnName("PubID");

                entity.Property(e => e.PubYear)
                    .IsRequired()
                    .HasColumnType("DATE");

                entity.HasOne(d => d.Gen)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.GenId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Pub)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.PubId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.ToTable("Employee");

                entity.Property(e => e.EmpId)
                    .HasColumnType("INT")
                    .ValueGeneratedNever()
                    .HasColumnName("EmpID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnType("NVARCHAR");

                entity.Property(e => e.BirthDate)
                    .IsRequired()
                    .HasColumnType("DATE");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnType("NVARCHAR");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("NVARCHAR");

                entity.Property(e => e.PassportData)
                    .IsRequired()
                    .HasColumnType("NVARCHAR")
                    .HasColumnName("passportData");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnType("NVARCHAR");

                entity.Property(e => e.PositionId)
                    .HasColumnType("INT")
                    .HasColumnName("PositionID");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.PositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.HasKey(e => e.GenId);

                entity.Property(e => e.GenId)
                    .HasColumnType("INT")
                    .ValueGeneratedNever()
                    .HasColumnName("GenID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("NVARCHAR");

                entity.Property(e => e.GenTitle)
                    .IsRequired()
                    .HasColumnType("NVARCHAR");
            });

            modelBuilder.Entity<IssuedBook>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BookId)
                    .HasColumnType("INT")
                    .HasColumnName("BookID");

                entity.Property(e => e.EmpId)
                    .HasColumnType("INT")
                    .HasColumnName("EmpID");

                entity.Property(e => e.IssueDate)
                    .IsRequired()
                    .HasColumnType("DATETIME");

                entity.Property(e => e.ReadId)
                    .HasColumnType("INT")
                    .HasColumnName("ReadID");

                entity.Property(e => e.ReturnDate)
                    .IsRequired()
                    .HasColumnType("DATETIME");

                entity.Property(e => e.ReturnMark)
                    .IsRequired()
                    .HasColumnType("NVARCHAR");

                entity.HasOne(d => d.Book)
                    .WithMany()
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Emp)
                    .WithMany()
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Read)
                    .WithMany()
                    .HasForeignKey(d => d.ReadId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.Property(e => e.PositionId)
                    .HasColumnType("INT")
                    .ValueGeneratedNever()
                    .HasColumnName("PositionID");

                entity.Property(e => e.Demands)
                    .IsRequired()
                    .HasColumnType("NVARCHAR");

                entity.Property(e => e.Duties)
                    .IsRequired()
                    .HasColumnType("NVARCHAR");

                entity.Property(e => e.PositionTitle)
                    .IsRequired()
                    .HasColumnType("NVARCHAR");

                entity.Property(e => e.Salary).HasColumnType("Float");
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.HasKey(e => e.PubId);

                entity.ToTable("Publisher");

                entity.Property(e => e.PubId)
                    .HasColumnType("INT")
                    .ValueGeneratedNever()
                    .HasColumnName("PubID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnType("NVARCHAR");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnType("NVARCHAR");

                entity.Property(e => e.PublicistTitle)
                    .IsRequired()
                    .HasColumnType("NVARCHAR");
            });

            modelBuilder.Entity<Reader>(entity =>
            {
                entity.HasKey(e => e.ReadId);

                entity.ToTable("Reader");

                entity.Property(e => e.ReadId)
                    .HasColumnType("INT")
                    .ValueGeneratedNever()
                    .HasColumnName("ReadID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnType("NVARCHAR");

                entity.Property(e => e.BirthDate)
                    .IsRequired()
                    .HasColumnType("DATE");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnType("NVARCHAR");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("NVARCHAR");

                entity.Property(e => e.PassportData)
                    .IsRequired()
                    .HasColumnType("NVARCHAR");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnType("NVARCHAR");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
