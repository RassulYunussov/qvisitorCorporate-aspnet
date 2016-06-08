using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using qvisitorCorp.Models;
using qvisitorCorporateaspnet.Models;

namespace qvisitorCorp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<qvCountry> Countries { get; set; }
        public DbSet<qvCity> Cities { get; set; }
        public DbSet<qvBranch> Branches { get; set; }
        public DbSet<qvDepartment> Departments { get; set; }
        public DbSet<qvCheckPoint> CheckPoints { get; set; }
        public DbSet<qvCompany> Companies { get; set; }
        public DbSet<qvGender> Genders { get; set; }
        public DbSet<qvHotEntrance> HotEntrances { get; set; }
        public DbSet<qvObject> Objects { get; set; }
        public DbSet<qvOrder> Orders { get; set; }
        public DbSet<qvOrderComment> OrderComments { get; set; }
        public DbSet<qvOrderType> OrderTypes { get; set; }
        public DbSet<qvOrderStatus> OrderStatuses { get; set; }
        public DbSet<qvVisitor> Visitors { get; set; }
        public DbSet<qvVisitiorPhoto> VisitorPhotos { get; set; }
        public DbSet<qvVisitorDoc> VisitorDocs { get; set; }
        public DbSet<qvEntranceType> EntranceTypes { get; set; }
        public DbSet<qvEntranceType> HotEntranceDocs { get; set; }
        public DbSet<qvVisitorScan> VisitorScan { get; set; }
        public DbSet<qvVisitorLuggage> VisitorLuggages { get; set; }



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
