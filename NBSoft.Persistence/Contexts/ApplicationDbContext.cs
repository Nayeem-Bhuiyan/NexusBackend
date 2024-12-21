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
        public DbSet<Country> Country { get; set; }
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
            modelBuilder.Entity<UserInfo>(entity => { entity.ToTable(name: "UserInfo"); });
            modelBuilder.Entity<IdentityRole>(entity => { entity.ToTable(name: "Roles"); });
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
