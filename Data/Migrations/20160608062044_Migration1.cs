using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace qvisitorCorp.Data.Migrations
{
    public partial class Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "qvGender",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_qvGender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "qvCity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    CityCountryId = table.Column<int>(nullable: true),
                    CountryID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_qvCity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_qvCity_qvCountry_CityCountryId",
                        column: x => x.CityCountryId,
                        principalTable: "qvCountry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "qvCompany",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    CompanyCountryId = table.Column<int>(nullable: true),
                    CounryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    qvCompanyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_qvCompany", x => x.Id);
                    table.ForeignKey(
                        name: "FK_qvCompany_qvCountry_CompanyCountryId",
                        column: x => x.CompanyCountryId,
                        principalTable: "qvCountry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_qvCompany_qvCompany_qvCompanyId",
                        column: x => x.qvCompanyId,
                        principalTable: "qvCompany",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "qvOrderComment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    Comment = table.Column<string>(nullable: true),
                    CommentDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_qvOrderComment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "qvOrderStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    Code = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_qvOrderStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "qvOrderType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    Code = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_qvOrderType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "qvVisitor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    GenderId = table.Column<int>(nullable: false),
                    VisitorGenderId = table.Column<int>(nullable: true),
                    birthdate = table.Column<DateTime>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    patronymic = table.Column<string>(nullable: true),
                    surname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_qvVisitor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_qvVisitor_qvGender_VisitorGenderId",
                        column: x => x.VisitorGenderId,
                        principalTable: "qvGender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "qvObject",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    CityId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ObjectCityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_qvObject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_qvObject_qvCity_ObjectCityId",
                        column: x => x.ObjectCityId,
                        principalTable: "qvCity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "qvBranch",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    BranchCityId = table.Column<int>(nullable: true),
                    BranchCompany = table.Column<int>(nullable: true),
                    CityId = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    HighBranchId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_qvBranch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_qvBranch_qvCity_BranchCityId",
                        column: x => x.BranchCityId,
                        principalTable: "qvCity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_qvBranch_qvCompany_BranchCompany",
                        column: x => x.BranchCompany,
                        principalTable: "qvCompany",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_qvBranch_qvBranch_HighBranchId",
                        column: x => x.HighBranchId,
                        principalTable: "qvBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "qvOrder",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    Closetime = table.Column<DateTime>(nullable: false),
                    Edate = table.Column<DateTime>(nullable: false),
                    Opentime = table.Column<DateTime>(nullable: false),
                    OrderOrderStatusId = table.Column<int>(nullable: true),
                    OrderOrderTypeId = table.Column<int>(nullable: true),
                    OrderStausid = table.Column<int>(nullable: false),
                    OrderTypeid = table.Column<int>(nullable: false),
                    Sdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_qvOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_qvOrder_qvOrderStatus_OrderOrderStatusId",
                        column: x => x.OrderOrderStatusId,
                        principalTable: "qvOrderStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_qvOrder_qvOrderType_OrderOrderTypeId",
                        column: x => x.OrderOrderTypeId,
                        principalTable: "qvOrderType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "qvCheckPoint",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    CheckPointObjectId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ObjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_qvCheckPoint", x => x.Id);
                    table.ForeignKey(
                        name: "FK_qvCheckPoint_qvObject_CheckPointObjectId",
                        column: x => x.CheckPointObjectId,
                        principalTable: "qvObject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "qvDepartment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    BranchId = table.Column<int>(nullable: false),
                    DepartmentBranchId = table.Column<int>(nullable: true),
                    Name = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_qvDepartment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_qvDepartment_qvBranch_DepartmentBranchId",
                        column: x => x.DepartmentBranchId,
                        principalTable: "qvBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "qvHotEntrance",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    Attendant = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    DepartmentId = table.Column<int>(nullable: false),
                    DocumentNumber = table.Column<string>(nullable: true),
                    HotEntranceDepartmentId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Organization = table.Column<string>(nullable: true),
                    Patronymic = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_qvHotEntrance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_qvHotEntrance_qvDepartment_HotEntranceDepartmentId",
                        column: x => x.HotEntranceDepartmentId,
                        principalTable: "qvDepartment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_qvVisitor_VisitorGenderId",
                table: "qvVisitor",
                column: "VisitorGenderId");

            migrationBuilder.CreateIndex(
                name: "IX_qvBranch_BranchCityId",
                table: "qvBranch",
                column: "BranchCityId");

            migrationBuilder.CreateIndex(
                name: "IX_qvBranch_BranchCompany",
                table: "qvBranch",
                column: "BranchCompany");

            migrationBuilder.CreateIndex(
                name: "IX_qvBranch_HighBranchId",
                table: "qvBranch",
                column: "HighBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_qvCheckPoint_CheckPointObjectId",
                table: "qvCheckPoint",
                column: "CheckPointObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_qvCity_CityCountryId",
                table: "qvCity",
                column: "CityCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_qvCompany_CompanyCountryId",
                table: "qvCompany",
                column: "CompanyCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_qvCompany_qvCompanyId",
                table: "qvCompany",
                column: "qvCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_qvDepartment_DepartmentBranchId",
                table: "qvDepartment",
                column: "DepartmentBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_qvHotEntrance_HotEntranceDepartmentId",
                table: "qvHotEntrance",
                column: "HotEntranceDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_qvObject_ObjectCityId",
                table: "qvObject",
                column: "ObjectCityId");

            migrationBuilder.CreateIndex(
                name: "IX_qvOrder_OrderOrderStatusId",
                table: "qvOrder",
                column: "OrderOrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_qvOrder_OrderOrderTypeId",
                table: "qvOrder",
                column: "OrderOrderTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "qvVisitor");

            migrationBuilder.DropTable(
                name: "qvCheckPoint");

            migrationBuilder.DropTable(
                name: "qvHotEntrance");

            migrationBuilder.DropTable(
                name: "qvOrder");

            migrationBuilder.DropTable(
                name: "qvOrderComment");

            migrationBuilder.DropTable(
                name: "qvGender");

            migrationBuilder.DropTable(
                name: "qvObject");

            migrationBuilder.DropTable(
                name: "qvDepartment");

            migrationBuilder.DropTable(
                name: "qvOrderStatus");

            migrationBuilder.DropTable(
                name: "qvOrderType");

            migrationBuilder.DropTable(
                name: "qvBranch");

            migrationBuilder.DropTable(
                name: "qvCity");

            migrationBuilder.DropTable(
                name: "qvCompany");
        }
    }
}
