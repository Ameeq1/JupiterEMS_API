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

        public virtual DbSet<ComparableEvidence> ComparableEvidences { get; set; } = null!;
        public virtual DbSet<EmailLogHistory> EmailLogHistories { get; set; } = null!;
        public virtual DbSet<MasterAddress> MasterAddresses { get; set; } = null!;
        public virtual DbSet<MasterAmenity> MasterAmenities { get; set; } = null!;
        public virtual DbSet<MasterAuditLog> MasterAuditLogs { get; set; } = null!;
        public virtual DbSet<MasterCity> MasterCities { get; set; } = null!;
        public virtual DbSet<MasterClient> MasterClients { get; set; } = null!;
        public virtual DbSet<MasterClientContact> MasterClientContacts { get; set; } = null!;
        public virtual DbSet<MasterClientType> MasterClientTypes { get; set; } = null!;
        public virtual DbSet<MasterConfig> MasterConfigs { get; set; } = null!;
        public virtual DbSet<MasterContact> MasterContacts { get; set; } = null!;
        public virtual DbSet<MasterCountry> MasterCountries { get; set; } = null!;
        public virtual DbSet<MasterCurrency> MasterCurrencies { get; set; } = null!;
        public virtual DbSet<MasterDepartment> MasterDepartments { get; set; } = null!;
        public virtual DbSet<MasterDesignation> MasterDesignations { get; set; } = null!;
        public virtual DbSet<MasterDictionary> MasterDictionaries { get; set; } = null!;
        public virtual DbSet<MasterDictionaryDetail> MasterDictionaryDetails { get; set; } = null!;
        public virtual DbSet<MasterDocument> MasterDocuments { get; set; } = null!;
        public virtual DbSet<MasterException> MasterExceptions { get; set; } = null!;
        public virtual DbSet<MasterLocation> MasterLocations { get; set; } = null!;
        public virtual DbSet<MasterModule> MasterModules { get; set; } = null!;
        public virtual DbSet<MasterNotification> MasterNotifications { get; set; } = null!;
        public virtual DbSet<MasterOwnershipType> MasterOwnershipTypes { get; set; } = null!;
        public virtual DbSet<MasterProperty> MasterProperties { get; set; } = null!;
        public virtual DbSet<MasterPropertyAmenity> MasterPropertyAmenities { get; set; } = null!;
        public virtual DbSet<MasterPropertyLocation> MasterPropertyLocations { get; set; } = null!;
        public virtual DbSet<MasterPropertySubType> MasterPropertySubTypes { get; set; } = null!;
        public virtual DbSet<MasterPropertyType> MasterPropertyTypes { get; set; } = null!;
        public virtual DbSet<MasterQualification> MasterQualifications { get; set; } = null!;
        public virtual DbSet<MasterResourceType> MasterResourceTypes { get; set; } = null!;
        public virtual DbSet<MasterRole> MasterRoles { get; set; } = null!;
        public virtual DbSet<MasterRoleModulePermission> MasterRoleModulePermissions { get; set; } = null!;
        public virtual DbSet<MasterState> MasterStates { get; set; } = null!;
        public virtual DbSet<MasterSubModule> MasterSubModules { get; set; } = null!;
        public virtual DbSet<MasterUser> MasterUsers { get; set; } = null!;
        public virtual DbSet<MasterUserAddress> MasterUserAddresses { get; set; } = null!;
        public virtual DbSet<MasterUserContact> MasterUserContacts { get; set; } = null!;
        public virtual DbSet<MasterValuationFee> MasterValuationFees { get; set; } = null!;
        public virtual DbSet<MasterValuationFeeType> MasterValuationFeeTypes { get; set; } = null!;
        public virtual DbSet<MasterValuationRequestApproverLevel> MasterValuationRequestApproverLevels { get; set; } = null!;
        public virtual DbSet<MasterValuationRequestVendorDd> MasterValuationRequestVendorDds { get; set; } = null!;
        public virtual DbSet<MasterValuationStatus> MasterValuationStatuses { get; set; } = null!;
        public virtual DbSet<MasterValuationStatus202401101> MasterValuationStatus202401101s { get; set; } = null!;
        public virtual DbSet<MasterValuationStatus202401102> MasterValuationStatus202401102s { get; set; } = null!;
        public virtual DbSet<MasterValuationStatus202401103> MasterValuationStatus202401103s { get; set; } = null!;
        public virtual DbSet<MasterValuationStatusDd> MasterValuationStatusDds { get; set; } = null!;
        public virtual DbSet<MasterVendor> MasterVendors { get; set; } = null!;
        public virtual DbSet<MasterVendorDd> MasterVendorDds { get; set; } = null!;
        public virtual DbSet<SiteDescription> SiteDescriptions { get; set; } = null!;
        public virtual DbSet<ValuationAssesment> ValuationAssesments { get; set; } = null!;
        public virtual DbSet<ValuationComparableEvidence> ValuationComparableEvidences { get; set; } = null!;
        public virtual DbSet<ValuationInvoice> ValuationInvoices { get; set; } = null!;
        public virtual DbSet<ValuationPayment> ValuationPayments { get; set; } = null!;
        public virtual DbSet<ValuationPaymentInvoice> ValuationPaymentInvoices { get; set; } = null!;
        public virtual DbSet<ValuationPaymentInvoiceMap> ValuationPaymentInvoiceMaps { get; set; } = null!;
        public virtual DbSet<ValuationQuotation> ValuationQuotations { get; set; } = null!;
        public virtual DbSet<ValuationRequest> ValuationRequests { get; set; } = null!;
        public virtual DbSet<ValuationRequestApproverLevel> ValuationRequestApproverLevels { get; set; } = null!;
        public virtual DbSet<ValuationRequestStatusHistory> ValuationRequestStatusHistories { get; set; } = null!;
        public virtual DbSet<ValuationSiteDescription> ValuationSiteDescriptions { get; set; } = null!;
        public virtual DbSet<VwClient> VwClients { get; set; } = null!;
        public virtual DbSet<VwDictonaryChild> VwDictonaryChildren { get; set; } = null!;
        public virtual DbSet<VwProperty> VwProperties { get; set; } = null!;
        public virtual DbSet<VwPropertyLocation> VwPropertyLocations { get; set; } = null!;
        public virtual DbSet<VwUser> VwUsers { get; set; } = null!;
        public virtual DbSet<VwValuationRequest> VwValuationRequests { get; set; } = null!;
        public virtual DbSet<VwValuationRequestDetail> VwValuationRequestDetails { get; set; } = null!;

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

            modelBuilder.Entity<ComparableEvidence>(entity =>
            {
                entity.ToTable("Comparable_Evidence", "dbo");

                entity.Property(e => e.AddtionalComments).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RateSqFt).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Remarks).HasMaxLength(250);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.ComparableEvidences)
                    .HasForeignKey(d => d.RequestId)
                    .HasConstraintName("FK_Comparable_Evidence_ValuationRequest");
            });

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

            modelBuilder.Entity<MasterAddress>(entity =>
            {
                entity.ToTable("Master_Address", "dbo");

                entity.Property(e => e.Address1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Address3)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AlternateEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AlternatePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AlternatePhoneExt)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Landlinephone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Landmark)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneExt)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PinNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Zone)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.MasterAddresses)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Master_Address_Master_City");
            });

            modelBuilder.Entity<MasterAmenity>(entity =>
            {
                entity.ToTable("Master_Amenity", "dbo");

                entity.Property(e => e.AmenityName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Icon)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
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

            modelBuilder.Entity<MasterClient>(entity =>
            {
                entity.ToTable("Master_Client", "dbo");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(752)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(((([FirstName]+' ')+[MiddleName])+' ')+[LastName])", false);

                entity.Property(e => e.Company)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LicenseNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Logo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TrnexpiryDate)
                    .HasColumnType("date")
                    .HasColumnName("TRNExpiryDate");

                entity.Property(e => e.Trnnumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TRNNumber");

                entity.HasOne(d => d.ClientType)
                    .WithMany(p => p.MasterClients)
                    .HasForeignKey(d => d.ClientTypeId)
                    .HasConstraintName("FK_DictionaryDetail_ClientTypeId");
            });

            modelBuilder.Entity<MasterClientContact>(entity =>
            {
                entity.ToTable("Master_ClientContact", "dbo");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Department)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Designation)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.MasterClientContacts)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Master_ClientContact_Master_Client");
            });

            modelBuilder.Entity<MasterClientType>(entity =>
            {
                entity.ToTable("Master_ClientType", "dbo");

                entity.Property(e => e.ClientType)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MasterConfig>(entity =>
            {
                entity.ToTable("Master_Config", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MasterContact>(entity =>
            {
                entity.ToTable("Master_Contact", "dbo");

                entity.Property(e => e.ContactPersonName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileExt)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TableName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterCountry>(entity =>
            {
                entity.ToTable("Master_Country", "dbo");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsdcountryCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ISDCountryCode");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MasterCurrency>(entity =>
            {
                entity.ToTable("Master_Currency", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MasterDepartment>(entity =>
            {
                entity.ToTable("Master_Department", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Department)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MasterDesignation>(entity =>
            {
                entity.ToTable("Master_Designation", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Designation)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MasterDictionary>(entity =>
            {
                entity.ToTable("Master_Dictionary", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DictionaryCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MasterDictionaryDetail>(entity =>
            {
                entity.ToTable("Master_DictionaryDetail", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Dictionary)
                    .WithMany(p => p.MasterDictionaryDetails)
                    .HasForeignKey(d => d.DictionaryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Master_Di__Dicti__12FDD1B2");
            });

            modelBuilder.Entity<MasterDocument>(entity =>
            {
                entity.ToTable("Master_Document", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FilePath)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FileType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TableName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
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

            modelBuilder.Entity<MasterLocation>(entity =>
            {
                entity.ToTable("Master_Location", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Latitude).HasMaxLength(255);

                entity.Property(e => e.LocationName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude).HasMaxLength(255);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Sector).HasMaxLength(255);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.MasterLocations)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Master_Location_Master_City");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.MasterLocations)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Master_Location_Master_Country");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.MasterLocations)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Master_Location_Master_State");
            });

            modelBuilder.Entity<MasterModule>(entity =>
            {
                entity.HasKey(e => e.ModuleId);

                entity.ToTable("Master_Module", "dbo");

                entity.Property(e => e.ControlName).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.HoverIcon)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Icon)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleName).HasMaxLength(250);

                entity.Property(e => e.ViewName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
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

                entity.HasOne(d => d.ValuationRequest)
                    .WithMany(p => p.MasterNotifications)
                    .HasForeignKey(d => d.ValuationRequestId)
                    .HasConstraintName("FK__Master_No__Valua__3429BB53");
            });

            modelBuilder.Entity<MasterOwnershipType>(entity =>
            {
                entity.ToTable("Master_OwnershipType", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OwnershipType)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterProperty>(entity =>
            {
                entity.ToTable("Master_Property", "dbo");

                entity.Property(e => e.AdditionalUnits)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Amenities)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BuildUpAreaSqFt).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.BuildUpAreaSqMtr).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Parking)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParkingBayNo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UnitNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ValuationPurpose)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Furnished)
                    .WithMany(p => p.MasterPropertyFurnisheds)
                    .HasForeignKey(d => d.FurnishedId)
                    .HasConstraintName("FK_DictionaryDetail_FurnishedId");

                entity.HasOne(d => d.OwnershipType)
                    .WithMany(p => p.MasterPropertyOwnershipTypes)
                    .HasForeignKey(d => d.OwnershipTypeId)
                    .HasConstraintName("FK_DictionaryDetail_OwnershipTypeId");

                entity.HasOne(d => d.UnitType)
                    .WithMany(p => p.MasterPropertyUnitTypes)
                    .HasForeignKey(d => d.UnitTypeId)
                    .HasConstraintName("FK_DictionaryDetail_UnitTypeId");
            });

            modelBuilder.Entity<MasterPropertyAmenity>(entity =>
            {
                entity.ToTable("Master_Property_Amenity", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Amenity)
                    .WithMany(p => p.MasterPropertyAmenities)
                    .HasForeignKey(d => d.AmenityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Master_Pr__Ameni__3DE82FB7");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.MasterPropertyAmenities)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Master_Pr__Prope__3EDC53F0");
            });

            modelBuilder.Entity<MasterPropertyLocation>(entity =>
            {
                entity.ToTable("Master_Property_Location", "dbo");

                entity.Property(e => e.Address1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BuildingProject)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Landmark)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Pincode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zone)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.MasterPropertyLocations)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Master_PropertyDetail_Master_Property");
            });

            modelBuilder.Entity<MasterPropertySubType>(entity =>
            {
                entity.ToTable("Master_PropertySubType", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PropertySubType)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.PropertyType)
                    .WithMany(p => p.MasterPropertySubTypes)
                    .HasForeignKey(d => d.PropertyTypeId)
                    .HasConstraintName("FK__Master_Pr__Prope__05A3D694");
            });

            modelBuilder.Entity<MasterPropertyType>(entity =>
            {
                entity.ToTable("Master_PropertyType", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PropertyType)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterQualification>(entity =>
            {
                entity.ToTable("Master_Qualification", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Grade)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Institute)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Qualification)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.YearOfInstitute)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterResourceType>(entity =>
            {
                entity.ToTable("Master_ResourceType", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ResourceType)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterRole>(entity =>
            {
                entity.ToTable("Master_Role", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RoleName).HasMaxLength(50);
            });

            modelBuilder.Entity<MasterRoleModulePermission>(entity =>
            {
                entity.HasKey(e => e.RoleModuleId)
                    .HasName("PK_RoleModulePermission");

                entity.ToTable("Master_RoleModulePermission", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MasterState>(entity =>
            {
                entity.ToTable("Master_State", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StateCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StateName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.MasterStates)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Master_State_Master_Country");
            });

            modelBuilder.Entity<MasterSubModule>(entity =>
            {
                entity.HasKey(e => e.SubModuleId);

                entity.ToTable("Master_SubModule", "dbo");

                entity.Property(e => e.ControlName).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.SubModuleName).HasMaxLength(250);
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

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.MasterUserDepartments)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_DictionaryDetail");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.MasterUserDesignations)
                    .HasForeignKey(d => d.DesignationId)
                    .HasConstraintName("FK_DictionaryDetail_Designation");
            });

            modelBuilder.Entity<MasterUserAddress>(entity =>
            {
                entity.ToTable("Master_UserAddress", "dbo");

                entity.Property(e => e.Address1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Address3)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PinNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.MasterUserAddresses)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Master_UserAddress_Master_City");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.MasterUserAddresses)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Master_UserAddress_Master_Country");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.MasterUserAddresses)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Master_UserAddress_Master_State");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MasterUserAddresses)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Master_UserAddress_Master_User");
            });

            modelBuilder.Entity<MasterUserContact>(entity =>
            {
                entity.ToTable("Master_UserContact", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MasterUserContacts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Master_UserContact_Master_User");
            });

            modelBuilder.Entity<MasterValuationFee>(entity =>
            {
                entity.ToTable("Master_ValuationFees", "dbo");

                entity.Property(e => e.CarpetAreaInSqFt)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CarpetAreaInSqMtr)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FixedvaluationFees).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OtherCharges).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TotalValuationFees).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ValuationFees).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Vat)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("VAT");
            });

            modelBuilder.Entity<MasterValuationFeeType>(entity =>
            {
                entity.ToTable("Master_ValuationFeeType", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ValuationFeeType)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterValuationRequestApproverLevel>(entity =>
            {
                entity.ToTable("Master_ValuationRequestApproverLevel", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FromAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ToAmount).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<MasterValuationRequestVendorDd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Master_ValuationRequest_Vendor_@dd");

                entity.Property(e => e.BackGroundColor).HasMaxLength(50);

                entity.Property(e => e.ColorCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterValuationStatus>(entity =>
            {
                entity.ToTable("Master_ValuationStatus", "dbo");

                entity.Property(e => e.BackGroundColor).HasMaxLength(50);

                entity.Property(e => e.ColorCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterValuationStatus202401101>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Master_ValuationStatus_20240110_1", "dbo");

                entity.Property(e => e.BackGroundColor).HasMaxLength(50);

                entity.Property(e => e.ColorCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterValuationStatus202401102>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Master_ValuationStatus_20240110_2", "dbo");

                entity.Property(e => e.BackGroundColor).HasMaxLength(50);

                entity.Property(e => e.ColorCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterValuationStatus202401103>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Master_ValuationStatus_20240110_3", "dbo");

                entity.Property(e => e.BackGroundColor).HasMaxLength(50);

                entity.Property(e => e.ColorCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterValuationStatusDd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Master_ValuationStatus_@dd", "dbo");

                entity.Property(e => e.BackGroundColor).HasMaxLength(50);

                entity.Property(e => e.ColorCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterVendor>(entity =>
            {
                entity.ToTable("Master_Vendor", "dbo");

                entity.Property(e => e.BusinessType)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EstimattionDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.VendorName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterVendorDd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Master_Vendor_@dd");

                entity.Property(e => e.BusinessType)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EstimattionDate).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.VendorName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SiteDescription>(entity =>
            {
                entity.ToTable("SiteDescription", "dbo");

                entity.Property(e => e.AdditionComment)
                    .HasMaxLength(750)
                    .IsUnicode(false);

                entity.Property(e => e.AdditionalNotes)
                    .HasMaxLength(750)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExternalArea).HasColumnType("decimal(16, 8)");

                entity.Property(e => e.InternalArea).HasColumnType("decimal(16, 8)");

                entity.Property(e => e.Location)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Others)
                    .HasMaxLength(750)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyCondition)
                    .HasMaxLength(750)
                    .IsUnicode(false);

                entity.Property(e => e.Storage)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.ValuationRequest)
                    .WithMany(p => p.SiteDescriptions)
                    .HasForeignKey(d => d.ValuationRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SiteDescription_ValuationRequest");
            });

            modelBuilder.Entity<ValuationAssesment>(entity =>
            {
                entity.ToTable("ValuationAssesment", "dbo");

                entity.Property(e => e.AnnualMaintainceCost).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InsuranceDetails).HasMaxLength(250);

                entity.Property(e => e.MarketRate).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MarketValue).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.ValuationAssesments)
                    .HasForeignKey(d => d.RequestId)
                    .HasConstraintName("FK_ValuationAssesment_ValuationRequest");
            });

            modelBuilder.Entity<ValuationComparableEvidence>(entity =>
            {
                entity.ToTable("ValuationComparableEvidence", "dbo");

                entity.Property(e => e.AddtionalComments).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RateSqFt).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Remarks).HasMaxLength(250);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.ValuationComparableEvidences)
                    .HasForeignKey(d => d.RequestId)
                    .HasConstraintName("FK_ValuationComparableEvidence_ValuationRequest");
            });

            modelBuilder.Entity<ValuationInvoice>(entity =>
            {
                entity.ToTable("ValuationInvoice", "dbo");

                entity.Property(e => e.AccountBankName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AccountHolderName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CardBankName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CardHolderName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CheckBankName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CheckDate).HasColumnType("date");

                entity.Property(e => e.CheckNumer)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeRecievedDate).HasColumnType("date");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpireDate).HasColumnType("date");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Note).IsUnicode(false);

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ReferenceNO");

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.ValuationRequest)
                    .WithMany(p => p.ValuationInvoices)
                    .HasForeignKey(d => d.ValuationRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Valuation__Valua__67DE6983");
            });

            modelBuilder.Entity<ValuationPayment>(entity =>
            {
                entity.ToTable("ValuationPayment", "dbo");

                entity.Property(e => e.AccountBankName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AccountHolderName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CardBankName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CardHolderName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CheckBankName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CheckDate).HasColumnType("date");

                entity.Property(e => e.CheckNumer)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeRecievedDate).HasColumnType("date");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpireDate).HasColumnType("date");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Note).IsUnicode(false);

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ReferenceNO");

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.ValuationRequest)
                    .WithMany(p => p.InverseValuationRequest)
                    .HasForeignKey(d => d.ValuationRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Valuation__Valua__4707859D");
            });

            modelBuilder.Entity<ValuationPaymentInvoice>(entity =>
            {
                entity.ToTable("ValuationPaymentInvoice", "dbo");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Note).IsUnicode(false);

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ReferenceNO");

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.HasOne(d => d.ValuationRequest)
                    .WithMany(p => p.InverseValuationRequest)
                    .HasForeignKey(d => d.ValuationRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Valuation__Valua__3E723F9C");
            });

            modelBuilder.Entity<ValuationPaymentInvoiceMap>(entity =>
            {
                entity.ToTable("ValuationPaymentInvoiceMap", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Note).IsUnicode(false);

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.ValuationPaymentInvoiceMaps)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Valuation__Invoi__5B0E7E4A");

                entity.HasOne(d => d.PaymentInvoice)
                    .WithMany(p => p.ValuationPaymentInvoiceMaps)
                    .HasForeignKey(d => d.PaymentInvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Valuation__Payme__5A1A5A11");
            });

            modelBuilder.Entity<ValuationQuotation>(entity =>
            {
                entity.ToTable("ValuationQuotation", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.InstructorCharges).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Note).IsUnicode(false);

                entity.Property(e => e.OtherCharges).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ReferenceNO");

                entity.Property(e => e.TotalFee).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ValuationFee).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Vat)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("VAT");

                entity.HasOne(d => d.ValuationRequest)
                    .WithMany(p => p.ValuationQuotations)
                    .HasForeignKey(d => d.ValuationRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Quotation__Valua__5E54FF49");
            });

            modelBuilder.Entity<ValuationRequest>(entity =>
            {
                entity.ToTable("ValuationRequest", "dbo");

                entity.Property(e => e.ApproverComment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ApproverUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.AssignRemark)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OtherReferenceNo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("OtherReferenceNO");

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ReferenceNO");

                entity.Property(e => e.StatusComment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ValuationDate).HasColumnType("date");

                entity.Property(e => e.ValuerComment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ValuerUpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Approver)
                    .WithMany(p => p.ValuationRequests)
                    .HasForeignKey(d => d.ApproverId)
                    .HasConstraintName("FK__Valuation__Appro__5D60DB10");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ValuationRequests)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Valuation__Clien__5A846E65");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.ValuationRequests)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Valuation__Prope__5C6CB6D7");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ValuationRequests)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Valuation__Statu__7226EDCC");
            });

            modelBuilder.Entity<ValuationRequestApproverLevel>(entity =>
            {
                entity.ToTable("ValuationRequestApproverLevel", "dbo");

                entity.Property(e => e.ApproverComment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ValuationRequest)
                    .WithMany(p => p.ValuationRequestApproverLevels)
                    .HasForeignKey(d => d.ValuationRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Valuation__Valua__0DCF0841");
            });

            modelBuilder.Entity<ValuationRequestStatusHistory>(entity =>
            {
                entity.ToTable("ValuationRequestStatusHistory", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.StatusComment)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ValuationSiteDescription>(entity =>
            {
                entity.ToTable("ValuationSiteDescription", "dbo");

                entity.Property(e => e.AdditionComment)
                    .HasMaxLength(750)
                    .IsUnicode(false);

                entity.Property(e => e.AdditionalNotes)
                    .HasMaxLength(750)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExternalArea).HasColumnType("decimal(16, 8)");

                entity.Property(e => e.InternalArea).HasColumnType("decimal(16, 8)");

                entity.Property(e => e.Location)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Others)
                    .HasMaxLength(750)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyCondition)
                    .HasMaxLength(750)
                    .IsUnicode(false);

                entity.Property(e => e.Storage)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.ValuationRequest)
                    .WithMany(p => p.ValuationSiteDescriptions)
                    .HasForeignKey(d => d.ValuationRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ValuationSiteDescription_ValuationRequest");
            });

            modelBuilder.Entity<VwClient>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Client", "dbo");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(752)
                    .IsUnicode(false);

                entity.Property(e => e.ClientType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Dictionary)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DictionaryCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LicenseNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Logo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TrnexpiryDate)
                    .HasColumnType("date")
                    .HasColumnName("TRNExpiryDate");

                entity.Property(e => e.Trnnumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TRNNumber");
            });

            modelBuilder.Entity<VwDictonaryChild>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_DictonaryChild", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetailDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DictionaryCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwProperty>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Property", "dbo");

                entity.Property(e => e.AdditionalUnits)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Amenities)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BuildUpAreaSqFt).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.BuildUpAreaSqMtr).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Furnished)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OwnershipType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Parking)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParkingBayNo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PropertySubType)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyType)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UnitNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UnitType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValuationPurpose)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwPropertyLocation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Property_Location", "dbo");

                entity.Property(e => e.Address1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BuildingProject)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CityName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Landmark)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Pincode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StateName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAddress)
                    .HasMaxLength(1510)
                    .IsUnicode(false);

                entity.Property(e => e.Zone)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_User", "dbo");

                entity.Property(e => e.ApproverLevel)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

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

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

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

                entity.Property(e => e.ResourceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleName).HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .HasMaxLength(501)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwValuationRequest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ValuationRequest", "dbo");

                entity.Property(e => e.ApproverComment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ApproverUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.AssignRemark)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BackGroundColor).HasMaxLength(50);

                entity.Property(e => e.ColorCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OtherReferenceNo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("OtherReferenceNO");

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ReferenceNO");

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StatusComment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StatusName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ValuationDate).HasColumnType("date");

                entity.Property(e => e.ValuerComment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ValuerUpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwValuationRequestDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ValuationRequest_Detail", "dbo");

                entity.Property(e => e.Approver)
                    .HasMaxLength(501)
                    .IsUnicode(false);

                entity.Property(e => e.ApproverComment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ApproverUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.AssignRemark)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BackGroundColor).HasMaxLength(50);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(752)
                    .IsUnicode(false);

                entity.Property(e => e.ClientType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ColorCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MethodOfValuation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OtherReferenceNo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("OtherReferenceNO");

                entity.Property(e => e.PropertyName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PropertySubType)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyType)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ReferenceNO");

                entity.Property(e => e.Requestor)
                    .HasMaxLength(501)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StatusComment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StatusName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ValuationDate).HasColumnType("date");

                entity.Property(e => e.ValuationPurpose)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Valuer)
                    .HasMaxLength(501)
                    .IsUnicode(false);

                entity.Property(e => e.ValuerComment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ValuerUpdateDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
