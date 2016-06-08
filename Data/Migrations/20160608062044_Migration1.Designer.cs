using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using qvisitorCorp.Data;

namespace qvisitorCorp.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160608062044_Migration1")]
    partial class Migration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rc2-20901");

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

                    b.Property<int?>("VisitorGenderId");

                    b.Property<DateTime>("birthdate");

                    b.Property<string>("name");

                    b.Property<string>("patronymic");

                    b.Property<string>("surname");

                    b.HasKey("Id");

                    b.HasIndex("VisitorGenderId");

                    b.ToTable("qvVisitor");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvBranch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BranchCityId");

                    b.Property<int?>("BranchCompany");

                    b.Property<int>("CityId");

                    b.Property<int>("CompanyId");

                    b.Property<int>("HighBranchId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("BranchCityId");

                    b.HasIndex("BranchCompany");

                    b.HasIndex("HighBranchId");

                    b.ToTable("qvBranch");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvCheckPoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CheckPointObjectId");

                    b.Property<string>("Name");

                    b.Property<int>("ObjectId");

                    b.HasKey("Id");

                    b.HasIndex("CheckPointObjectId");

                    b.ToTable("qvCheckPoint");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvCity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CityCountryId");

                    b.Property<int>("CountryID");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CityCountryId");

                    b.ToTable("qvCity");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CompanyCountryId");

                    b.Property<int>("CounryId");

                    b.Property<string>("Name");

                    b.Property<int?>("qvCompanyId");

                    b.HasKey("Id");

                    b.HasIndex("CompanyCountryId");

                    b.HasIndex("qvCompanyId");

                    b.ToTable("qvCompany");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvDepartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BranchId");

                    b.Property<int?>("DepartmentBranchId");

                    b.Property<int>("Name");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentBranchId");

                    b.ToTable("qvDepartment");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvHotEntrance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Attendant");

                    b.Property<string>("Comment");

                    b.Property<int>("DepartmentId");

                    b.Property<string>("DocumentNumber");

                    b.Property<int?>("HotEntranceDepartmentId");

                    b.Property<string>("Name");

                    b.Property<string>("Organization");

                    b.Property<string>("Patronymic");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.HasIndex("HotEntranceDepartmentId");

                    b.ToTable("qvHotEntrance");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvObject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CityId");

                    b.Property<string>("Name");

                    b.Property<int?>("ObjectCityId");

                    b.HasKey("Id");

                    b.HasIndex("ObjectCityId");

                    b.ToTable("qvObject");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Closetime");

                    b.Property<DateTime>("Edate");

                    b.Property<DateTime>("Opentime");

                    b.Property<int?>("OrderOrderStatusId");

                    b.Property<int?>("OrderOrderTypeId");

                    b.Property<int>("OrderStausid");

                    b.Property<int>("OrderTypeid");

                    b.Property<DateTime>("Sdate");

                    b.HasKey("Id");

                    b.HasIndex("OrderOrderStatusId");

                    b.HasIndex("OrderOrderTypeId");

                    b.ToTable("qvOrder");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvOrderComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<DateTime>("CommentDate");

                    b.HasKey("Id");

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
                        .HasForeignKey("VisitorGenderId");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvBranch", b =>
                {
                    b.HasOne("qvisitorCorporateaspnet.Models.qvCity")
                        .WithMany()
                        .HasForeignKey("BranchCityId");

                    b.HasOne("qvisitorCorporateaspnet.Models.qvCompany")
                        .WithMany()
                        .HasForeignKey("BranchCompany");

                    b.HasOne("qvisitorCorporateaspnet.Models.qvBranch")
                        .WithMany()
                        .HasForeignKey("HighBranchId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvCheckPoint", b =>
                {
                    b.HasOne("qvisitorCorporateaspnet.Models.qvObject")
                        .WithMany()
                        .HasForeignKey("CheckPointObjectId");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvCity", b =>
                {
                    b.HasOne("qvisitorCorp.Models.qvCountry")
                        .WithMany()
                        .HasForeignKey("CityCountryId");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvCompany", b =>
                {
                    b.HasOne("qvisitorCorp.Models.qvCountry")
                        .WithMany()
                        .HasForeignKey("CompanyCountryId");

                    b.HasOne("qvisitorCorporateaspnet.Models.qvCompany")
                        .WithMany()
                        .HasForeignKey("qvCompanyId");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvDepartment", b =>
                {
                    b.HasOne("qvisitorCorporateaspnet.Models.qvBranch")
                        .WithMany()
                        .HasForeignKey("DepartmentBranchId");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvHotEntrance", b =>
                {
                    b.HasOne("qvisitorCorporateaspnet.Models.qvDepartment")
                        .WithMany()
                        .HasForeignKey("HotEntranceDepartmentId");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvObject", b =>
                {
                    b.HasOne("qvisitorCorporateaspnet.Models.qvCity")
                        .WithMany()
                        .HasForeignKey("ObjectCityId");
                });

            modelBuilder.Entity("qvisitorCorporateaspnet.Models.qvOrder", b =>
                {
                    b.HasOne("qvisitorCorporateaspnet.Models.qvOrderStatus")
                        .WithMany()
                        .HasForeignKey("OrderOrderStatusId");

                    b.HasOne("qvisitorCorporateaspnet.Models.qvOrderType")
                        .WithMany()
                        .HasForeignKey("OrderOrderTypeId");
                });
        }
    }
}
