using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NBSoft.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccademicClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccademicClass", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccademicYear",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    aliasName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    fromDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    toDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActiveYear = table.Column<bool>(type: "bit", nullable: true),
                    lockMonth = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccademicYear", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AddressType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: true),
                    deletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    deletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BloodGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CityCorporation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityCorporation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    shortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    mobileDialingCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    symbolText = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    symbolSign = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    decimalAllow = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationBoardIntitution",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    typeName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationBoardIntitution", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationGroupFaculty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupOrFacultyType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationGroupFaculty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationLevel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EvaluationType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluationType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeatureCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    shortName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GradeScale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    basicSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    maximumBasicSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    probitionSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    createdBy = table.Column<int>(type: "int", nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updatedBy = table.Column<int>(type: "int", nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    deletedBy = table.Column<int>(type: "int", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: true),
                    deletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradeScale", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HolydayType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HolydayType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Institution",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    shortName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    displayName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    eiinNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    establishDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    websiteUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    founderNames = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    presentOwnerNames = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    contactPerson = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    contactNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    alternetContactNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    email = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    logoName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    alternetEmail = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    isMotherInstitution = table.Column<bool>(type: "bit", nullable: true),
                    reportSortingOrder = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    baseUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    createdBy = table.Column<int>(type: "int", nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updatedBy = table.Column<int>(type: "int", nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    deletedBy = table.Column<int>(type: "int", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: true),
                    deletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institution", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    shortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocationMapping",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mappingAreaName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationMapping", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MajorGroupSubject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    isGroup = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MajorGroupSubject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaritalStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MobileBank",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    shortName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    createdBy = table.Column<int>(type: "int", nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updatedBy = table.Column<int>(type: "int", nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    deletedBy = table.Column<int>(type: "int", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: true),
                    deletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileBank", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Occupation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    shortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QoutaInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QoutaInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Relation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Religion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Religion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalaryType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    shortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SmartModule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    shortName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmartModule", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    reportDisplayName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    totalMarks = table.Column<int>(type: "int", nullable: false),
                    reportSortingOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransferType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInfo",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProfilePicUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: true),
                    LastLoginTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    createdBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: true),
                    deletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    deletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccademicSection",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccademicClassId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccademicSection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccademicSection_AccademicClass_AccademicClassId",
                        column: x => x.AccademicClassId,
                        principalTable: "AccademicClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bank",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    shortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BankTypeId = table.Column<int>(type: "int", nullable: true),
                    description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bank_BankType_BankTypeId",
                        column: x => x.BankTypeId,
                        principalTable: "BankType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CityCorporationCounsil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    counsilNo = table.Column<int>(type: "int", nullable: true),
                    CityCorporationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityCorporationCounsil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CityCorporationCounsil_CityCorporation_CityCorporationId",
                        column: x => x.CityCorporationId,
                        principalTable: "CityCorporation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Division",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Division", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Division_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ExamController = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    SortingOrder = table.Column<int>(type: "int", nullable: false),
                    EducationLevelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Education_EducationLevel_EducationLevelId",
                        column: x => x.EducationLevelId,
                        principalTable: "EducationLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InstitutionalDivision",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    displayName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    isMainDivision = table.Column<bool>(type: "bit", nullable: true),
                    InstitutionId = table.Column<int>(type: "int", nullable: true),
                    createdBy = table.Column<int>(type: "int", nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updatedBy = table.Column<int>(type: "int", nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    deletedBy = table.Column<int>(type: "int", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: true),
                    deletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstitutionalDivision", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstitutionalDivision_Institution_InstitutionId",
                        column: x => x.InstitutionId,
                        principalTable: "Institution",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SmartFeature",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    areaName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    controllerName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    actionName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    FeatureCategoryId = table.Column<int>(type: "int", nullable: true),
                    SmartModuleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmartFeature", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SmartFeature_FeatureCategory_FeatureCategoryId",
                        column: x => x.FeatureCategoryId,
                        principalTable: "FeatureCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SmartFeature_SmartModule_SmartModuleId",
                        column: x => x.SmartModuleId,
                        principalTable: "SmartModule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubjectDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectId = table.Column<int>(type: "int", nullable: true),
                    AccademicClassId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubjectDetails_AccademicClass_AccademicClassId",
                        column: x => x.AccademicClassId,
                        principalTable: "AccademicClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubjectDetails_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_UserInfo_UserId",
                        column: x => x.UserId,
                        principalTable: "UserInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_UserInfo_UserId",
                        column: x => x.UserId,
                        principalTable: "UserInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRoles_UserInfo_UserId",
                        column: x => x.UserId,
                        principalTable: "UserInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_UserInfo_UserId",
                        column: x => x.UserId,
                        principalTable: "UserInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "District",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DivisionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.Id);
                    table.ForeignKey(
                        name: "FK_District_Division_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "Division",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    shortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    contact = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    isMainBranch = table.Column<bool>(type: "bit", nullable: true),
                    reportSortingOrder = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    InstitutionId = table.Column<int>(type: "int", nullable: false),
                    InstitutionalDivisionId = table.Column<int>(type: "int", nullable: false),
                    createdBy = table.Column<int>(type: "int", nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updatedBy = table.Column<int>(type: "int", nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    deletedBy = table.Column<int>(type: "int", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: true),
                    deletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Branch_Institution_InstitutionId",
                        column: x => x.InstitutionId,
                        principalTable: "Institution",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Branch_InstitutionalDivision_InstitutionalDivisionId",
                        column: x => x.InstitutionalDivisionId,
                        principalTable: "InstitutionalDivision",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmailConfiguration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fromName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    fromMail = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ccEmail = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    bccEmail = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    smtpServer = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    serverPort = table.Column<int>(type: "int", nullable: false),
                    hostName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    userName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    password = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    isServerUseSsl = table.Column<bool>(type: "bit", nullable: false),
                    InstitutionalDivisionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailConfiguration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailConfiguration_InstitutionalDivision_InstitutionalDivisionId",
                        column: x => x.InstitutionalDivisionId,
                        principalTable: "InstitutionalDivision",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GeneralConfiguration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    purpose = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    configLabel = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    configName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    configOptions = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    configValue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InstitutionalDivisionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralConfiguration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeneralConfiguration_InstitutionalDivision_InstitutionalDivisionId",
                        column: x => x.InstitutionalDivisionId,
                        principalTable: "InstitutionalDivision",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Holiday",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    fromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    toDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccademicYearId = table.Column<int>(type: "int", nullable: false),
                    HolydayTypeId = table.Column<int>(type: "int", nullable: true),
                    InstitutionalDivisionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holiday", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Holiday_AccademicYear_AccademicYearId",
                        column: x => x.AccademicYearId,
                        principalTable: "AccademicYear",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Holiday_HolydayType_HolydayTypeId",
                        column: x => x.HolydayTypeId,
                        principalTable: "HolydayType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Holiday_InstitutionalDivision_InstitutionalDivisionId",
                        column: x => x.InstitutionalDivisionId,
                        principalTable: "InstitutionalDivision",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Thana",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DistrictId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thana", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Thana_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "District",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BankBranch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    isMainBranch = table.Column<bool>(type: "bit", nullable: false),
                    contact = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    email = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    BankId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankBranch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankBranch_Bank_BankId",
                        column: x => x.BankId,
                        principalTable: "Bank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BankBranch_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BranchIncharge",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fatherName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    motherName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    contactNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fromDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    toDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BranchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchIncharge", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BranchIncharge_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Building",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    buildingPosition = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    buildingType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BranchId = table.Column<int>(type: "int", nullable: true),
                    createdBy = table.Column<int>(type: "int", nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updatedBy = table.Column<int>(type: "int", nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    deletedBy = table.Column<int>(type: "int", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: true),
                    deletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Building", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Building_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    shortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BranchId = table.Column<int>(type: "int", nullable: true),
                    createdBy = table.Column<int>(type: "int", nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updatedBy = table.Column<int>(type: "int", nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    deletedBy = table.Column<int>(type: "int", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: true),
                    deletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Department_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Shift",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    shortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fromDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    toDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    beginTime = table.Column<TimeOnly>(type: "time", nullable: true),
                    endTime = table.Column<TimeOnly>(type: "time", nullable: true),
                    shiftUser = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shift", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shift_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Municipality",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ThanaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipality", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Municipality_Thana_ThanaId",
                        column: x => x.ThanaId,
                        principalTable: "Thana",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Union",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ThanaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Union", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Union_Thana_ThanaId",
                        column: x => x.ThanaId,
                        principalTable: "Thana",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BuildingRoom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    floorNumber = table.Column<int>(type: "int", nullable: true),
                    roomNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingId = table.Column<int>(type: "int", nullable: false),
                    createdBy = table.Column<int>(type: "int", nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updatedBy = table.Column<int>(type: "int", nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    deletedBy = table.Column<int>(type: "int", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: true),
                    deletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingRoom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BuildingRoom_Building_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Building",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Designation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    shortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    createdBy = table.Column<int>(type: "int", nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updatedBy = table.Column<int>(type: "int", nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    deletedBy = table.Column<int>(type: "int", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: true),
                    deletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Designation_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Section",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Section_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MunicipalityCounsil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    counsilNo = table.Column<int>(type: "int", nullable: true),
                    MunicipalityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MunicipalityCounsil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MunicipalityCounsil_Municipality_MunicipalityId",
                        column: x => x.MunicipalityId,
                        principalTable: "Municipality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Word",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    wordNo = table.Column<int>(type: "int", nullable: true),
                    UnionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Word", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Word_Union_UnionId",
                        column: x => x.UnionId,
                        principalTable: "Union",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClassRoom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    code = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    BranchId = table.Column<int>(type: "int", nullable: true),
                    AccademicClassId = table.Column<int>(type: "int", nullable: true),
                    AccademicSectionId = table.Column<int>(type: "int", nullable: true),
                    BuildingRoomId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassRoom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassRoom_AccademicClass_AccademicClassId",
                        column: x => x.AccademicClassId,
                        principalTable: "AccademicClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassRoom_AccademicSection_AccademicSectionId",
                        column: x => x.AccademicSectionId,
                        principalTable: "AccademicSection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassRoom_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassRoom_BuildingRoom_BuildingRoomId",
                        column: x => x.BuildingRoomId,
                        principalTable: "BuildingRoom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AccademicClass",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "One" },
                    { 2, "Two" },
                    { 3, "Three" },
                    { 4, "Four" },
                    { 5, "Five" },
                    { 6, "Six" },
                    { 7, "Seven" },
                    { 8, "Eight" },
                    { 9, "Nine" },
                    { 10, "Ten" },
                    { 11, "Eleven" },
                    { 12, "Twelve" }
                });

            migrationBuilder.InsertData(
                table: "AddressType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Present" },
                    { 2, "Permanent" }
                });

            migrationBuilder.InsertData(
                table: "BloodGroup",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "A+" },
                    { 2, "A-" },
                    { 3, "B+" },
                    { 4, "B-" },
                    { 5, "O+" },
                    { 6, "O-" },
                    { 7, "AB+" },
                    { 8, "AB-" }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "Name", "code", "mobileDialingCode", "shortName" },
                values: new object[] { 1, "Bangladesh", "101", "+880", "BD" });

            migrationBuilder.InsertData(
                table: "EducationGroupFaculty",
                columns: new[] { "Id", "GroupOrFacultyType", "Name" },
                values: new object[,]
                {
                    { 1, "GF", "Science" },
                    { 2, "GF", "Business" },
                    { 3, "GF", "Arts" }
                });

            migrationBuilder.InsertData(
                table: "EducationLevel",
                columns: new[] { "Id", "Name", "code" },
                values: new object[,]
                {
                    { 1, "Primary", "P101" },
                    { 2, "Secondary", "S201" },
                    { 3, "Higher Secondary", "HS301" },
                    { 4, "Under-graduate", "UG401" },
                    { 5, "Post-graduate", "PG501" },
                    { 6, "Dimploma", "D101" },
                    { 7, "Post-Graduate Dimploma", "PGD201" }
                });

            migrationBuilder.InsertData(
                table: "EvaluationType",
                columns: new[] { "Id", "Name", "code" },
                values: new object[,]
                {
                    { 1, "Promotion", "PM" },
                    { 2, "Demotion", "DM" },
                    { 3, "Increment", "IC" },
                    { 4, "Decrement", "DR" }
                });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "Id", "Name", "shortName" },
                values: new object[,]
                {
                    { 1, "Male", "M" },
                    { 2, "Female", "Fe" },
                    { 3, "Third-Gender", "TG" }
                });

            migrationBuilder.InsertData(
                table: "HolydayType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Govt" },
                    { 2, "Eid" },
                    { 3, "Puza" },
                    { 4, "Weekly" },
                    { 5, "Others" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Name", "shortName" },
                values: new object[,]
                {
                    { 1, "English", "ENG" },
                    { 2, "Bangla", "BAN" }
                });

            migrationBuilder.InsertData(
                table: "MajorGroupSubject",
                columns: new[] { "Id", "Name", "code", "isGroup" },
                values: new object[,]
                {
                    { 1, "Science", "101", true },
                    { 2, "Commerce", "102", true },
                    { 3, "Arts", "103", true }
                });

            migrationBuilder.InsertData(
                table: "MaritalStatus",
                columns: new[] { "Id", "Name", "code" },
                values: new object[,]
                {
                    { 1, "Married", "101" },
                    { 2, "Unmarried", "102" },
                    { 3, "Divorced", "103" },
                    { 4, "Widowed", "104" }
                });

            migrationBuilder.InsertData(
                table: "MobileBank",
                columns: new[] { "Id", "Name", "code", "createdBy", "createdDate", "deletedBy", "deletedDate", "isDeleted", "shortName", "updatedBy", "updatedDate" },
                values: new object[,]
                {
                    { 1, "Bikash", null, null, null, null, null, null, "BK", null, null },
                    { 2, "Nagad", null, null, null, null, null, null, "ND", null, null },
                    { 3, "Rocket", null, null, null, null, null, null, "RKT", null, null }
                });

            migrationBuilder.InsertData(
                table: "QoutaInfo",
                columns: new[] { "Id", "Name", "code" },
                values: new object[,]
                {
                    { 1, "Freedom", "101" },
                    { 2, "Disable", "102" }
                });

            migrationBuilder.InsertData(
                table: "Relation",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Father" },
                    { 2, "Mother" },
                    { 3, "Brother" },
                    { 4, "Sister" },
                    { 5, "Uncle" },
                    { 6, "Aunty" },
                    { 7, "Grand-Father" },
                    { 8, "Grand-Mother" }
                });

            migrationBuilder.InsertData(
                table: "Religion",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Islam" },
                    { 2, "Hindu" },
                    { 3, "Christian" },
                    { 4, "Buddist" }
                });

            migrationBuilder.InsertData(
                table: "SalaryType",
                columns: new[] { "Id", "Name", "shortName" },
                values: new object[,]
                {
                    { 1, "Consolidated", "C" },
                    { 2, "Regular", "R" }
                });

            migrationBuilder.InsertData(
                table: "TransferType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Branch" },
                    { 2, "Department" },
                    { 3, "Section" },
                    { 4, "InstitutionalDivision" },
                    { 5, "Institution" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccademicSection_AccademicClassId",
                table: "AccademicSection",
                column: "AccademicClassId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bank_BankTypeId",
                table: "Bank",
                column: "BankTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BankBranch_BankId",
                table: "BankBranch",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_BankBranch_BranchId",
                table: "BankBranch",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Branch_InstitutionalDivisionId",
                table: "Branch",
                column: "InstitutionalDivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Branch_InstitutionId",
                table: "Branch",
                column: "InstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchIncharge_BranchId",
                table: "BranchIncharge",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Building_BranchId",
                table: "Building",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingRoom_BuildingId",
                table: "BuildingRoom",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_CityCorporationCounsil_CityCorporationId",
                table: "CityCorporationCounsil",
                column: "CityCorporationId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassRoom_AccademicClassId",
                table: "ClassRoom",
                column: "AccademicClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassRoom_AccademicSectionId",
                table: "ClassRoom",
                column: "AccademicSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassRoom_BranchId",
                table: "ClassRoom",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassRoom_BuildingRoomId",
                table: "ClassRoom",
                column: "BuildingRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_BranchId",
                table: "Department",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Designation_DepartmentId",
                table: "Designation",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_District_DivisionId",
                table: "District",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Division_CountryId",
                table: "Division",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Education_EducationLevelId",
                table: "Education",
                column: "EducationLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailConfiguration_InstitutionalDivisionId",
                table: "EmailConfiguration",
                column: "InstitutionalDivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralConfiguration_InstitutionalDivisionId",
                table: "GeneralConfiguration",
                column: "InstitutionalDivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Holiday_AccademicYearId",
                table: "Holiday",
                column: "AccademicYearId");

            migrationBuilder.CreateIndex(
                name: "IX_Holiday_HolydayTypeId",
                table: "Holiday",
                column: "HolydayTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Holiday_InstitutionalDivisionId",
                table: "Holiday",
                column: "InstitutionalDivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitutionalDivision_InstitutionId",
                table: "InstitutionalDivision",
                column: "InstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_Municipality_ThanaId",
                table: "Municipality",
                column: "ThanaId");

            migrationBuilder.CreateIndex(
                name: "IX_MunicipalityCounsil_MunicipalityId",
                table: "MunicipalityCounsil",
                column: "MunicipalityId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Section_DepartmentId",
                table: "Section",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Shift_BranchId",
                table: "Shift",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_SmartFeature_FeatureCategoryId",
                table: "SmartFeature",
                column: "FeatureCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SmartFeature_SmartModuleId",
                table: "SmartFeature",
                column: "SmartModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectDetails_AccademicClassId",
                table: "SubjectDetails",
                column: "AccademicClassId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectDetails_SubjectId",
                table: "SubjectDetails",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Thana_DistrictId",
                table: "Thana",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Union_ThanaId",
                table: "Union",
                column: "ThanaId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "UserInfo",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "UserInfo",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Word_UnionId",
                table: "Word",
                column: "UnionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddressType");

            migrationBuilder.DropTable(
                name: "BankBranch");

            migrationBuilder.DropTable(
                name: "BloodGroup");

            migrationBuilder.DropTable(
                name: "BranchIncharge");

            migrationBuilder.DropTable(
                name: "CityCorporationCounsil");

            migrationBuilder.DropTable(
                name: "ClassRoom");

            migrationBuilder.DropTable(
                name: "Currency");

            migrationBuilder.DropTable(
                name: "Designation");

            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "EducationBoardIntitution");

            migrationBuilder.DropTable(
                name: "EducationGroupFaculty");

            migrationBuilder.DropTable(
                name: "EmailConfiguration");

            migrationBuilder.DropTable(
                name: "EvaluationType");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "GeneralConfiguration");

            migrationBuilder.DropTable(
                name: "GradeScale");

            migrationBuilder.DropTable(
                name: "Holiday");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "LocationMapping");

            migrationBuilder.DropTable(
                name: "MajorGroupSubject");

            migrationBuilder.DropTable(
                name: "MaritalStatus");

            migrationBuilder.DropTable(
                name: "MobileBank");

            migrationBuilder.DropTable(
                name: "MunicipalityCounsil");

            migrationBuilder.DropTable(
                name: "Occupation");

            migrationBuilder.DropTable(
                name: "QoutaInfo");

            migrationBuilder.DropTable(
                name: "Relation");

            migrationBuilder.DropTable(
                name: "Religion");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "SalaryType");

            migrationBuilder.DropTable(
                name: "Section");

            migrationBuilder.DropTable(
                name: "Shift");

            migrationBuilder.DropTable(
                name: "SmartFeature");

            migrationBuilder.DropTable(
                name: "SubjectDetails");

            migrationBuilder.DropTable(
                name: "TransferType");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Word");

            migrationBuilder.DropTable(
                name: "Bank");

            migrationBuilder.DropTable(
                name: "CityCorporation");

            migrationBuilder.DropTable(
                name: "AccademicSection");

            migrationBuilder.DropTable(
                name: "BuildingRoom");

            migrationBuilder.DropTable(
                name: "EducationLevel");

            migrationBuilder.DropTable(
                name: "AccademicYear");

            migrationBuilder.DropTable(
                name: "HolydayType");

            migrationBuilder.DropTable(
                name: "Municipality");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "FeatureCategory");

            migrationBuilder.DropTable(
                name: "SmartModule");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "UserInfo");

            migrationBuilder.DropTable(
                name: "Union");

            migrationBuilder.DropTable(
                name: "BankType");

            migrationBuilder.DropTable(
                name: "AccademicClass");

            migrationBuilder.DropTable(
                name: "Building");

            migrationBuilder.DropTable(
                name: "Thana");

            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "InstitutionalDivision");

            migrationBuilder.DropTable(
                name: "Division");

            migrationBuilder.DropTable(
                name: "Institution");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
