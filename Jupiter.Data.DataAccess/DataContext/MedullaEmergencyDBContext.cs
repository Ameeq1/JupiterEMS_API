using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Jupiter.Data.DataAccess.Entity;

namespace Jupiter.Data.DataAccess.DataContext
{
    public partial class MedullaEmergencyDBContext : DbContext
    {
        public MedullaEmergencyDBContext()
        {
        }

        public MedullaEmergencyDBContext(DbContextOptions<MedullaEmergencyDBContext> options)
            : base(options)
        {
        }

      
        public virtual DbSet<EmailLogHistory> EmailLogHistories { get; set; } = null!;
       
        public virtual DbSet<MasterAuditLog> MasterAuditLogs { get; set; } = null!;
        public virtual DbSet<MasterCity> MasterCities { get; set; } = null!;
      
        public virtual DbSet<MasterException> MasterExceptions { get; set; } = null!;
       
        public virtual DbSet<MasterNotification> MasterNotifications { get; set; } = null!;
      
        public virtual DbSet<MasterUser> MasterUsers { get; set; } = null!;
     
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=180.149.241.172;Initial Catalog=EltizamDB_Dev;Persist Security Info=True;User ID=eltizam_dbUser;pwd=eltizam234@#$;Connection Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("eltizam_dbUser");

          

            modelBuilder.Entity<EmailLogHistory>(entity =>
            {
                entity.ToTable("EmailLogHistory", "dbo");

                entity.HasIndex(e => e.Id, "uq_EmailHistory")
                    .IsUnique();

                entity.Property(e => e.BccAddress)
                    .HasMaxLength(365)
                    .IsUnicode(false);

                entity.Property(e => e.Body).IsUnicode(false);

                entity.Property(e => e.Ccaddress)
                    .HasMaxLength(365)
                    .IsUnicode(false)
                    .HasColumnName("CCAddress");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EmailResponse).IsUnicode(false);

                entity.Property(e => e.FromAddress)
                    .HasMaxLength(365)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Subject)
                    .HasMaxLength(365)
                    .IsUnicode(false);

                entity.Property(e => e.ToAddress)
                    .HasMaxLength(365)
                    .IsUnicode(false);
            });

          
            modelBuilder.Entity<MasterAuditLog>(entity =>
            {
                entity.ToTable("Master_AuditLog", "dbo");

                entity.Property(e => e.ActionType).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ParentTableName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TableName).HasMaxLength(100);
            });

            modelBuilder.Entity<MasterCity>(entity =>
            {
                entity.ToTable("Master_City", "dbo");

                entity.Property(e => e.CityName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Stdcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STDCode");
            });

           

            modelBuilder.Entity<MasterException>(entity =>
            {
                entity.HasKey(e => e.ExceptionId);

                entity.ToTable("Master_Exception", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Message).HasMaxLength(500);

                entity.Property(e => e.Source).HasMaxLength(500);

                entity.Property(e => e.StrackTrace).HasMaxLength(4000);
            });

          
            modelBuilder.Entity<MasterNotification>(entity =>
            {
                entity.ToTable("Master_Notification", "dbo");

                entity.HasIndex(e => new { e.Id, e.ValuationRequestId }, "idx_idvalreqid");

                entity.Property(e => e.Body).IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ReadDate).HasColumnType("datetime");

                entity.Property(e => e.SentDatetime).HasColumnType("datetime");

                entity.Property(e => e.Subject)
                    .HasMaxLength(900)
                    .IsUnicode(false);

                entity.Property(e => e.ToEmails).IsUnicode(false);

                
            });

           
            modelBuilder.Entity<MasterUser>(entity =>
            {
                entity.ToTable("Master_User", "dbo");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ForgotPasswordDateTime).HasColumnType("datetime");

                entity.Property(e => e.ForgotPasswordToken)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                //entity.Property(e => e.Gender)
                //    .HasMaxLength(10)
                //    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LicenseNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(501)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(([FirstName]+' ')+[LastName])", false);

            });

          
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
