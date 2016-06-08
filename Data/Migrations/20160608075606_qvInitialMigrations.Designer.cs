using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using qvisitorCorp.Data;

namespace qvisitorCorp.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160608075606_qvInitialMigrations")]
    partial class qvInitialMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rc2-20896");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("qvisitorCorp.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("qvisitorCorp.Models.qvCountry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("qvCountry");
                });

            modelBuilder.Entity("qvisitorCorp.Models.qvGender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("qvGender");
                });

            modelBuilder.Entity("qvisitorCorp.Models.qvVisitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GenderId");

                    b.Property<DateTime>("birthdate");

                    b.Property<string>("name");

                    b.Property<string>("patronymic");

                    b.Property<string>("surname");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.ToTable("qvVisitor");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvBranch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CityId");

                    b.Property<int>("CompanyId");

                    b.Property<int>("HighBranchId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("HighBranchId");

                    b.ToTable("qvBranch");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvCheckPoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("ObjectId");

                    b.HasKey("Id");

                    b.HasIndex("ObjectId");

                    b.ToTable("qvCheckPoint");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvCity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountryID");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CountryID");

                    b.ToTable("qvCity");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CounryId");

                    b.Property<string>("Name");

                    b.Property<int?>("qvCompanyId");

                    b.HasKey("Id");

                    b.HasIndex("CounryId");

                    b.HasIndex("qvCompanyId");

                    b.ToTable("qvCompany");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvDepartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BranchId");

                    b.Property<int>("Name");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("qvDepartment");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvEntranceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("qvEntranceType");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvHotEntrance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Attendant");

                    b.Property<string>("Comment");

                    b.Property<int>("DepartmentId");

                    b.Property<string>("DocumentNumber");

                    b.Property<string>("Name");

                    b.Property<string>("Organization");

                    b.Property<string>("Patronymic");

                    b.Property<string>("Surname");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("UserId");

                    b.ToTable("qvHotEntrance");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvHotEntranceDoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("Document");

                    b.Property<int>("HotEntranceId");

                    b.HasKey("Id");

                    b.HasIndex("HotEntranceId");

                    b.ToTable("qvHotEntranceDoc");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvObject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CityId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("qvObject");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Closetime");

                    b.Property<DateTime>("Edate");

                    b.Property<DateTime>("Opentime");

                    b.Property<int>("OrderStausid");

                    b.Property<int>("OrderTypeid");

                    b.Property<DateTime>("Sdate");

                    b.HasKey("Id");

                    b.HasIndex("OrderStausid");

                    b.HasIndex("OrderTypeid");

                    b.ToTable("qvOrder");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvOrderComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<DateTime>("CommentDate");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("qvOrderComment");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvOrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("qvOrderStatus");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvOrderType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("qvOrderType");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvVisitiorPhoto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("Photo");

                    b.Property<DateTime>("PhotoDate");

                    b.Property<int>("VisitorId");

                    b.HasKey("Id");

                    b.HasIndex("VisitorId");

                    b.ToTable("qvVisitorPhoto");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvVisitorDoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ExpireDate");

                    b.Property<DateTime>("IssueDate");

                    b.Property<string>("Name");

                    b.Property<string>("Number");

                    b.Property<string>("Surname");

                    b.Property<int>("VisitorId");

                    b.HasKey("Id");

                    b.HasIndex("VisitorId");

                    b.ToTable("qvVisitorDoc");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvVisitorLuggage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Luggage");

                    b.Property<int>("OrderId");

                    b.Property<int>("VisitorId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("VisitorId");

                    b.ToTable("qvVisitorLuggage");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvVisitorScan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("Scan");

                    b.Property<int>("VisitorId");

                    b.HasKey("Id");

                    b.HasIndex("VisitorId");

                    b.ToTable("qvVisitorScan");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("qvisitorCorp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("qvisitorCorp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("qvisitorCorp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("qvisitorCorp.Models.qvVisitor", b =>
                {
                    b.HasOne("qvisitorCorp.Models.qvGender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvBranch", b =>
                {
                    b.HasOne("qvisitorCorporateaspnet.Models.qvCity")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("qvisitorCorporateaspnet.Models.qvCompany")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("qvisitorCorporateaspnet.Models.qvBranch")
                        .WithMany()
                        .HasForeignKey("HighBranchId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvCheckPoint", b =>
                {
                    b.HasOne("qvisitorCorporateaspnet.Models.qvObject")
                        .WithMany()
                        .HasForeignKey("ObjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvCity", b =>
                {
                    b.HasOne("qvisitorCorp.Models.qvCountry")
                        .WithMany()
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvCompany", b =>
                {
                    b.HasOne("qvisitorCorp.Models.qvCountry")
                        .WithMany()
                        .HasForeignKey("CounryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("qvisitorCorporateaspnet.Models.qvCompany")
                        .WithMany()
                        .HasForeignKey("qvCompanyId");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvDepartment", b =>
                {
                    b.HasOne("qvisitorCorporateaspnet.Models.qvBranch")
                        .WithMany()
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvHotEntrance", b =>
                {
                    b.HasOne("qvisitorCorporateaspnet.Models.qvDepartment")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("qvisitorCorp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvHotEntranceDoc", b =>
                {
                    b.HasOne("qvisitorCorporateaspnet.Models.qvHotEntrance")
                        .WithMany()
                        .HasForeignKey("HotEntranceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvObject", b =>
                {
                    b.HasOne("qvisitorCorporateaspnet.Models.qvCity")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvOrder", b =>
                {
                    b.HasOne("qvisitorCorporateaspnet.Models.qvOrderStatus")
                        .WithMany()
                        .HasForeignKey("OrderStausid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("qvisitorCorporateaspnet.Models.qvOrderType")
                        .WithMany()
                        .HasForeignKey("OrderTypeid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvOrderComment", b =>
                {
                    b.HasOne("qvisitorCorp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvVisitiorPhoto", b =>
                {
                    b.HasOne("qvisitorCorp.Models.qvVisitor")
                        .WithMany()
                        .HasForeignKey("VisitorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvVisitorDoc", b =>
                {
                    b.HasOne("qvisitorCorp.Models.qvVisitor")
                        .WithMany()
                        .HasForeignKey("VisitorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvVisitorLuggage", b =>
                {
                    b.HasOne("qvisitorCorporateaspnet.Models.qvOrder")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("qvisitorCorp.Models.qvVisitor")
                        .WithMany()
                        .HasForeignKey("VisitorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvVisitorScan", b =>
                {
                    b.HasOne("qvisitorCorp.Models.qvVisitor")
                        .WithMany()
                        .HasForeignKey("VisitorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
