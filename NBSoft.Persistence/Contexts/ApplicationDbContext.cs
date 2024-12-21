using NBSoft.Domain.Common;
using NBSoft.Domain.Common.Interfaces;
using Microsoft.EntityFrameworkCore;

using System.Reflection;
using NBSoft.Domain.Model.MasterPanel;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore.Design;
namespace NBSoft.Persistence.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }


        private readonly IDomainEventDispatcher _dispatcher;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option, IDomainEventDispatcher dispatcher = null) : base(option)
        {
            _dispatcher = dispatcher;
        }


        #region MasterPanel
        public DbSet<SmartModule> SmartModule { get; set; }
        public DbSet<FeatureCategory> FeatureCategory { get; set; }
        public DbSet<SmartFeature> SmartFeature { get; set; }
        public DbSet<AccademicClass> AccademicClass { get; set; }
        public DbSet<AccademicSection> AccademicSection { get; set; }
        public DbSet<AccademicYear> AccademicYear { get; set; }
        public DbSet<AddressType> AddressType { get; set; }
        public DbSet<Bank> Bank { get; set; }
        public DbSet<BankBranch> BankBranch { get; set; }
        public DbSet<BankType> BankType { get; set; }
        public DbSet<BloodGroup> BloodGroup { get; set; }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<BranchIncharge> BranchIncharge { get; set; }
        public DbSet<Building> Building { get; set; }
        public DbSet<BuildingRoom> BuildingRoom { get; set; }
        public DbSet<CityCorporation> CityCorporation { get; set; }
        public DbSet<CityCorporationCounsil> CityCorporationCounsil { get; set; }
        public DbSet<ClassRoom> ClassRoom { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Designation> Designation { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<Division> Division { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<EducationLevel> EducationLevel { get; set; }
        public DbSet<EmailConfiguration> EmailConfiguration { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<GeneralConfiguration> GeneralConfiguration { get; set; }
        public DbSet<GradeScale> GradeScale { get; set; }
        //public DbSet<GradeScaleDetails> GradeScaleDetails { get; set; }
        public DbSet<Holiday> Holiday { get; set; }
        public DbSet<HolydayType> HolydayType { get; set; }
        public DbSet<Institution> Institution { get; set; }
        public DbSet<InstitutionalDivision> InstitutionalDivision { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<LocationMapping> LocationMapping { get; set; }
        public DbSet<MobileBank> MobileBank { get; set; }
        public DbSet<Municipality> Municipality { get; set; }
        public DbSet<MunicipalityCounsil> MunicipalityCounsil { get; set; }
        public DbSet<Occupation> Occupation { get; set; }
        public DbSet<Relation> Relation { get; set; }
        public DbSet<Religion> Religion { get; set; }
        public DbSet<SalaryType> SalaryType { get; set; }
        public DbSet<Section> Section { get; set; }
        public DbSet<Shift> Shift { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<SubjectDetails> SubjectDetails { get; set; }
        public DbSet<Thana> Thana { get; set; }
        public DbSet<Union> Union { get; set; }
        public DbSet<Word> Word { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<EducationBoardIntitution> EducationBoardIntitution { get; set; }
        public DbSet<MajorGroupSubject> MajorGroupSubject { get; set; }
        public DbSet<TransferType> TransferType { get; set; }
        public DbSet<EducationGroupFaculty> EducationGroupFaculty { get; set; }
        public DbSet<EvaluationType> EvaluationType { get; set; }

        public DbSet<QoutaInfo> QoutaInfo { get; set; }
        public DbSet<MaritalStatus> MaritalStatus { get; set; }

        #endregion

        #region View_Model_Register
        //public DbSet<VmDropdownInfo> VmDropdownInfo { get; set; } = null;
        #endregion

        #region Audit_Trail
        //public override int SaveChanges()
        //{
        //    HandleAuditEntries();
        //    return base.SaveChanges();
        //}

        //public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        //{
        //    HandleAuditEntries();
        //    return await base.SaveChangesAsync(cancellationToken);
        //}

        //private void HandleAuditEntries()
        //{
        //    var entries = ChangeTracker.Entries()
        //        .Where(e => e.Entity is BaseAuditableEntity && (e.State == EntityState.Added || e.State == EntityState.Modified || e.State == EntityState.Deleted));

        //    foreach (var entry in entries)
        //    {
        //        var entity = (BaseAuditableEntity)entry.Entity;

        //        switch (entry.State)
        //        {
        //            case EntityState.Added:
        //                entity.createdDate = DateTime.UtcNow;
        //                entity.updatedDate = null;
        //                entity.deletedDate = null;
        //                entity.isDeleted = false;
        //                break;

        //            case EntityState.Modified:
        //                entity.updatedDate = DateTime.UtcNow;
        //                break;

        //            case EntityState.Deleted:
        //                entry.State = EntityState.Modified; // Soft delete
        //                entity.isDeleted = true;
        //                entity.deletedDate = DateTime.UtcNow;
        //                break;
        //        }
        //    }
        //}
        #endregion

        #region Suppress PendingModelChangesWarning_Error_Solutionfor.Net9.0
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=NAYEEM-BHUIYAN;Initial Catalog=NBSoftDB_API;User ID=sa;Password=open;Persist Security Info=True;Trust Server Certificate=True;");
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Disable cascading delete
            // Disable cascading delete for all foreign keys
            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
            #endregion


            #region Rename_Identity_TableName

            #region MyRegion
            modelBuilder.Entity<IdentityUserLogin<string>>()
        .HasKey(l => new { l.LoginProvider, l.ProviderKey });

            modelBuilder.Entity<IdentityUserRole<string>>()
                .HasKey(r => new { r.UserId, r.RoleId });

            modelBuilder.Entity<IdentityUserClaim<string>>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<IdentityUserToken<string>>()
                .HasKey(t => new { t.UserId, t.LoginProvider, t.Name });

            #endregion



            modelBuilder.Entity<UserInfo>(entity => { entity.ToTable(name: "UserInfo"); });
            modelBuilder.Entity<UserRole>(entity => { entity.ToTable(name: "Roles"); });
            modelBuilder.Entity<IdentityUserRole<string>>(entity => { entity.ToTable("UserRoles"); });
            modelBuilder.Entity<IdentityUserClaim<string>>(entity => { entity.ToTable("UserClaims"); });
            modelBuilder.Entity<IdentityUserLogin<string>>(entity => { entity.ToTable("UserLogins"); });
            modelBuilder.Entity<IdentityUserToken<string>>(entity => { entity.ToTable("UserTokens"); });
            modelBuilder.Entity<IdentityRoleClaim<string>>(entity => { entity.ToTable("RoleClaims"); });
            #endregion

            #region SEED_DATA

            #region MasterPanel

            #region Country
            modelBuilder.Entity<Country>().HasData(new List<Country>
            {
                new Country // 1
                {
                    Id=1,
                    Name = "Bangladesh",
                    code = "101",
                    mobileDialingCode="+880",
                    shortName="BD"
                }
            });
            #endregion

            #region SalaryType
            modelBuilder.Entity<SalaryType>().HasData(new List<SalaryType>
            {
                new SalaryType // 1
                {
                    Id=1,
                    Name = "Consolidated",
                    shortName="C"
                },
                new SalaryType // 1
                {
                    Id=2,
                    Name = "Regular",
                    shortName="R"
                }
            });


            #endregion

            #region languageName
            modelBuilder.Entity<Language>().HasData(new List<Language>
            {
                new Language // 1
                {
                    Id=1,
                    Name = "English",
                    shortName="ENG"
                },
               new Language // 1
                {
                   Id=2,
                    Name = "Bangla",
                    shortName="BAN"
                }
            });
            #endregion

            #region MobileBank
            modelBuilder.Entity<MobileBank>().HasData(new List<MobileBank>
            {
                new MobileBank
                {
                    Id=1,
                    Name = "Bikash",
                    shortName="BK"
                },
               new MobileBank
                {
                   Id=2,
                    Name = "Nagad",
                    shortName="ND"
                }
               ,
               new MobileBank
               {
                   Id=3,
                   Name = "Rocket",
                   shortName="RKT"
               }
            });
            #endregion

            #region EducationLevel
            modelBuilder.Entity<EducationLevel>().HasData(new List<EducationLevel>
            {
                new EducationLevel
                {
                    Id=1,
                    Name = "Primary",
                    code="P101"
                },
                new EducationLevel
                {
                    Id=2,
                    Name = "Secondary",
                    code="S201"
                },
                new EducationLevel
                {
                    Id=3,
                    Name = "Higher Secondary",
                    code="HS301"
                },
                 new EducationLevel
                {
                     Id=4,
                    Name = "Under-graduate",
                    code="UG401"
                },
                  new EducationLevel
                {
                      Id=5,
                    Name = "Post-graduate",
                    code="PG501"
                },
                  new EducationLevel
                {
                      Id=6,
                    Name = "Dimploma",
                    code="D101"
                },
                new EducationLevel
                {
                    Id=7,
                    Name = "Post-Graduate Dimploma",
                    code="PGD201"
                },
            });
            #endregion

            #region Gender
            modelBuilder.Entity<Gender>().HasData(new List<Gender>
            {
                new Gender
                {
                    Id=1,
                    Name = "Male",
                    shortName="M"
                },
                new Gender
                {
                    Id=2,
                    Name = "Female",
                    shortName="Fe"
                },
                new Gender
                {
                    Id=3,
                    Name = "Third-Gender",
                    shortName="TG"
                }
            });
            #endregion

            #region HolydayType
            modelBuilder.Entity<HolydayType>().HasData(new List<HolydayType>
            {
                new HolydayType
                {
                    Id=1,
                    Name = "Govt"
                },
               new HolydayType
                {
                   Id=2,
                    Name = "Eid"
                },
               new HolydayType
                {Id=3,
                   Name = "Puza"
                },
               new HolydayType
                {
                   Id=4,
                    Name = "Weekly"
                },
                new HolydayType
                {
                    Id=5,
                    Name = "Others"
                },
            });
            #endregion

            #region AccademicClass
            modelBuilder.Entity<AccademicClass>().HasData(new List<AccademicClass>
            {
                new AccademicClass // 1
                {
                    Id=1,
                    Name = "One"
                },
               new AccademicClass // 1
                {
                   Id=2,
                    Name = "Two",
                },
               new AccademicClass // 1
                {Id = 3,
                    Name = "Three",
                }
               ,
               new AccademicClass // 1
                {Id = 4,
                    Name = "Four",
                }
               ,
               new AccademicClass // 1
                {
                   Id=5,
                    Name = "Five",
                }
               ,
               new AccademicClass // 1
                {
                   Id=6,
                    Name = "Six",
                }
               ,
               new AccademicClass // 1
                {
                   Id=7,
                    Name = "Seven",
                }
               ,
               new AccademicClass // 1
                {
                   Id=8,
                    Name = "Eight",
                }
               ,
               new AccademicClass // 1
                {
                   Id=9,
                    Name = "Nine",
                }
               ,
               new AccademicClass // 1
                {
                   Id=10,
                    Name = "Ten",
                }
               ,
               new AccademicClass // 1
                {
                   Id=11,
                    Name = "Eleven",
                }
               ,
               new AccademicClass // 1
                {
                    Id=12,
                    Name = "Twelve",
                }
            });
            #endregion

            #region AddressType
            modelBuilder.Entity<AddressType>().HasData(new List<AddressType>
            {
                new AddressType // 1
                {
                    Id=1,
                    Name = "Present"
                },
                 new AddressType // 1
                {
                     Id=2,
                    Name = "Permanent"
                }
            });
            #endregion

            #region BloodGroup
            modelBuilder.Entity<BloodGroup>().HasData(new List<BloodGroup>
            {
                new BloodGroup
                {
                    Id=1,
                    Name = "A+"
                },
                 new BloodGroup
                {Id=2,
                    Name = "A-"
                },
                 new BloodGroup
                {
                     Id=3,
                    Name = "B+"
                },
                 new BloodGroup
                {
                     Id=4,
                    Name = "B-"
                },
                 new BloodGroup
                {
                     Id=5,
                    Name = "O+"
                },
                 new BloodGroup
                {
                     Id=6,
                    Name = "O-"
                },
                 new BloodGroup
                {
                     Id=7,
                    Name = "AB+"
                },
                 new BloodGroup
                {
                     Id=8,
                    Name = "AB-"
                }
            });
            #endregion

            #region Relation
            modelBuilder.Entity<Relation>().HasData(new List<Relation>
            {
                new Relation
                {
                    Id=1,
                    Name = "Father"
                },
                 new Relation
                {Id = 2,
                    Name = "Mother"
                },
                 new Relation
                {
                     Id=3,
                    Name = "Brother"
                },
                 new Relation
                {
                     Id=4,
                    Name = "Sister"
                }
                 ,
                 new Relation
                {
                     Id=5,
                    Name = "Uncle"
                }
                 ,
                 new Relation
                {
                     Id=6,
                    Name = "Aunty"
                }
                 ,
                 new Relation
                {
                     Id=7,
                    Name = "Grand-Father"
                }
                 ,
                 new Relation
                {
                     Id=8,
                    Name = "Grand-Mother"
                }
            });
            #endregion

            #region Religion

            modelBuilder.Entity<Religion>().HasData(new List<Religion>
            {
                new Religion
                {
                    Id=1,
                    Name = "Islam"
                },
                 new Religion
                {
                     Id=2,
                    Name = "Hindu"
                },
                 new Religion
                {
                     Id=3,
                    Name = "Christian"
                },
                 new Religion
                {
                     Id=4,
                    Name = "Buddist"
                }
            });
            #endregion

            #region MajorGroupSubject
            modelBuilder.Entity<MajorGroupSubject>().HasData(new List<MajorGroupSubject>
            {
                new MajorGroupSubject // 1
                {
                    Id=1,
                    Name = "Science",
                    code = "101",
                    isGroup=true
                },
                new MajorGroupSubject // 1
                {
                    Id=2,
                    Name = "Commerce",
                    code = "102",
                    isGroup=true
                },
                 new MajorGroupSubject // 1
                {
                    Id=3,
                    Name = "Arts",
                    code = "103",
                    isGroup=true
                }
            });
            #endregion

            #region TransferType
            modelBuilder.Entity<TransferType>().HasData(new List<TransferType>
            {

                new TransferType
                {
                    Id=1,
                    Name = "Branch"
                },
                 new TransferType
                {
                     Id=2,
                    Name = "Department"
                },
                 new TransferType
                {
                     Id=3,
                    Name = "Section"
                },
                 new TransferType
                {
                     Id=4,
                    Name = "InstitutionalDivision"
                },
                  new TransferType
                {
                     Id=5,
                    Name = "Institution"
                }
            });
            #endregion




            #region QoutaInfo
            modelBuilder.Entity<QoutaInfo>().HasData(new List<QoutaInfo>
            {

                new QoutaInfo
                {
                    Id=1,
                    Name = "Freedom",
                    code="101"
                },
                 new QoutaInfo
                {
                     Id=2,
                    Name = "Disable",
                    code="102"
                }
            });



            #endregion

            #region MaritalStatus
            modelBuilder.Entity<MaritalStatus>().HasData(new List<MaritalStatus>
            {

                new MaritalStatus
                {
                    Id=1,
                    Name = "Married",
                    code="101"
                },
                 new MaritalStatus
                {
                     Id=2,
                    Name = "Unmarried",
                    code="102"
                }
                 ,
                 new MaritalStatus
                {
                     Id=3,
                    Name = "Divorced",
                    code="103"
                }
                 ,
                 new MaritalStatus
                {
                     Id=4,
                    Name = "Widowed",
                    code="104"
                }
            });
            #endregion


            #region EducationGroupFaculty
            modelBuilder.Entity<EducationGroupFaculty>().HasData(new List<EducationGroupFaculty>
            {

                new EducationGroupFaculty
                {
                    Id=1,
                    Name = "Science",
                    GroupOrFacultyType = "GF"
                },
                 new EducationGroupFaculty
                {
                     Id=2,
                    Name = "Business",
                    GroupOrFacultyType = "GF"
                },
                 new EducationGroupFaculty
                {
                     Id=3,
                    Name = "Arts",
                    GroupOrFacultyType = "GF"
                }
            });



            #endregion

            #region EvaluationType
            modelBuilder.Entity<EvaluationType>().HasData(new List<EvaluationType>
            {

                new EvaluationType
                {
                    Id=1,
                    Name = "Promotion",
                    code="PM"
                },
                 new EvaluationType
                {
                     Id=2,
                    Name = "Demotion",
                    code="DM"
                },
                 new EvaluationType
                {
                     Id=3,
                    Name = "Increment",
                    code="IC"
                },
                 new EvaluationType
                {
                     Id=4,
                    Name = "Decrement",
                    code="DR"
                }
            });



            #endregion
            #endregion

            #endregion

            #region View_Model_Register
            //modelBuilder.Entity<VmDropdownInfo>().HasNoKey().ToView("view_name_that_doesnt_exist");
            #endregion

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        #region SaveChange_Events
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            int result = await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

            // ignore events if no dispatcher provided
            if (_dispatcher == null) return result;

            // dispatch events only if save was successful
            var entitiesWithEvents = ChangeTracker.Entries<BaseEntity>()
                .Select(e => e.Entity)
                .Where(e => e.DomainEvents.Any())
                .ToArray();

            await _dispatcher.DispatchAndClearEvents(entitiesWithEvents);

            return result;
        }

        public override int SaveChanges()
        {
            return SaveChangesAsync().GetAwaiter().GetResult();
        }
        #endregion
    }
}
