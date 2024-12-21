IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
CREATE TABLE [AccademicClass] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NOT NULL,
    CONSTRAINT [PK_AccademicClass] PRIMARY KEY ([Id])
);

CREATE TABLE [AccademicYear] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(100) NULL,
    [aliasName] nvarchar(100) NULL,
    [fromDate] datetime2 NULL,
    [toDate] datetime2 NULL,
    [IsActiveYear] bit NULL,
    [lockMonth] datetime2 NULL,
    CONSTRAINT [PK_AccademicYear] PRIMARY KEY ([Id])
);

CREATE TABLE [AddressType] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(100) NOT NULL,
    CONSTRAINT [PK_AddressType] PRIMARY KEY ([Id])
);

CREATE TABLE [BankType] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    CONSTRAINT [PK_BankType] PRIMARY KEY ([Id])
);

CREATE TABLE [BloodGroup] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    CONSTRAINT [PK_BloodGroup] PRIMARY KEY ([Id])
);

CREATE TABLE [CityCorporation] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(100) NOT NULL,
    [code] nvarchar(100) NULL,
    CONSTRAINT [PK_CityCorporation] PRIMARY KEY ([Id])
);

CREATE TABLE [Country] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NOT NULL,
    [code] nvarchar(50) NULL,
    [shortName] nvarchar(50) NULL,
    [mobileDialingCode] nvarchar(50) NULL,
    CONSTRAINT [PK_Country] PRIMARY KEY ([Id])
);

CREATE TABLE [Currency] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NULL,
    [symbolText] nvarchar(120) NULL,
    [symbolSign] nvarchar(120) NULL,
    [decimalAllow] int NULL,
    CONSTRAINT [PK_Currency] PRIMARY KEY ([Id])
);

CREATE TABLE [EducationBoardIntitution] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NULL,
    [typeName] nvarchar(150) NULL,
    CONSTRAINT [PK_EducationBoardIntitution] PRIMARY KEY ([Id])
);

CREATE TABLE [EducationGroupFaculty] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [GroupOrFacultyType] nvarchar(max) NULL,
    CONSTRAINT [PK_EducationGroupFaculty] PRIMARY KEY ([Id])
);

CREATE TABLE [EducationLevel] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(100) NOT NULL,
    [code] nvarchar(30) NULL,
    CONSTRAINT [PK_EducationLevel] PRIMARY KEY ([Id])
);

CREATE TABLE [EvaluationType] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [code] nvarchar(max) NULL,
    CONSTRAINT [PK_EvaluationType] PRIMARY KEY ([Id])
);

CREATE TABLE [FeatureCategory] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NULL,
    CONSTRAINT [PK_FeatureCategory] PRIMARY KEY ([Id])
);

CREATE TABLE [Gender] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(120) NULL,
    [shortName] nvarchar(30) NULL,
    CONSTRAINT [PK_Gender] PRIMARY KEY ([Id])
);

CREATE TABLE [GradeScale] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NULL,
    [basicSalary] decimal(18,2) NOT NULL,
    [maximumBasicSalary] decimal(18,2) NOT NULL,
    [probitionSalary] decimal(18,2) NOT NULL,
    [createdBy] int NULL,
    [createdDate] datetime2 NULL,
    [updatedBy] int NULL,
    [updatedDate] datetime2 NULL,
    [deletedBy] int NULL,
    [isDeleted] bit NULL,
    [deletedDate] datetime2 NULL,
    CONSTRAINT [PK_GradeScale] PRIMARY KEY ([Id])
);

CREATE TABLE [HolydayType] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NULL,
    CONSTRAINT [PK_HolydayType] PRIMARY KEY ([Id])
);

CREATE TABLE [Institution] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(250) NOT NULL,
    [shortName] nvarchar(80) NULL,
    [displayName] nvarchar(250) NULL,
    [code] nvarchar(50) NULL,
    [eiinNumber] nvarchar(100) NULL,
    [establishDate] datetime2 NULL,
    [address] nvarchar(250) NULL,
    [websiteUrl] nvarchar(250) NULL,
    [founderNames] nvarchar(500) NULL,
    [presentOwnerNames] nvarchar(500) NULL,
    [contactPerson] nvarchar(250) NULL,
    [contactNumber] nvarchar(30) NULL,
    [alternetContactNumber] nvarchar(30) NULL,
    [email] nvarchar(120) NULL,
    [logoName] nvarchar(120) NULL,
    [alternetEmail] nvarchar(120) NULL,
    [isMotherInstitution] bit NULL,
    [reportSortingOrder] nvarchar(100) NULL,
    [baseUrl] nvarchar(1000) NULL,
    [createdBy] int NULL,
    [createdDate] datetime2 NULL,
    [updatedBy] int NULL,
    [updatedDate] datetime2 NULL,
    [deletedBy] int NULL,
    [isDeleted] bit NULL,
    [deletedDate] datetime2 NULL,
    CONSTRAINT [PK_Institution] PRIMARY KEY ([Id])
);

CREATE TABLE [Language] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NULL,
    [shortName] nvarchar(50) NULL,
    CONSTRAINT [PK_Language] PRIMARY KEY ([Id])
);

CREATE TABLE [LocationMapping] (
    [Id] int NOT NULL IDENTITY,
    [mappingAreaName] nvarchar(100) NOT NULL,
    CONSTRAINT [PK_LocationMapping] PRIMARY KEY ([Id])
);

CREATE TABLE [MajorGroupSubject] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NOT NULL,
    [code] nvarchar(50) NULL,
    [isGroup] bit NOT NULL,
    CONSTRAINT [PK_MajorGroupSubject] PRIMARY KEY ([Id])
);

CREATE TABLE [MaritalStatus] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(100) NULL,
    [code] nvarchar(20) NULL,
    CONSTRAINT [PK_MaritalStatus] PRIMARY KEY ([Id])
);

CREATE TABLE [MobileBank] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NULL,
    [shortName] nvarchar(100) NULL,
    [code] nvarchar(100) NULL,
    [createdBy] int NULL,
    [createdDate] datetime2 NULL,
    [updatedBy] int NULL,
    [updatedDate] datetime2 NULL,
    [deletedBy] int NULL,
    [isDeleted] bit NULL,
    [deletedDate] datetime2 NULL,
    CONSTRAINT [PK_MobileBank] PRIMARY KEY ([Id])
);

CREATE TABLE [Occupation] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NOT NULL,
    [shortName] nvarchar(50) NULL,
    CONSTRAINT [PK_Occupation] PRIMARY KEY ([Id])
);

CREATE TABLE [QoutaInfo] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(100) NULL,
    [code] nvarchar(20) NULL,
    CONSTRAINT [PK_QoutaInfo] PRIMARY KEY ([Id])
);

CREATE TABLE [Relation] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(120) NOT NULL,
    CONSTRAINT [PK_Relation] PRIMARY KEY ([Id])
);

CREATE TABLE [Religion] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NOT NULL,
    CONSTRAINT [PK_Religion] PRIMARY KEY ([Id])
);

CREATE TABLE [RoleClaims] (
    [Id] int NOT NULL IDENTITY,
    [RoleId] nvarchar(max) NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_RoleClaims] PRIMARY KEY ([Id])
);

CREATE TABLE [Roles] (
    [Id] nvarchar(450) NOT NULL,
    [Description] nvarchar(max) NULL,
    [IpAddress] nvarchar(max) NULL,
    [createdBy] nvarchar(120) NULL,
    [createdDate] datetime2 NULL,
    [updatedBy] nvarchar(120) NULL,
    [updatedDate] datetime2 NULL,
    [isDeleted] bit NULL,
    [deletedBy] nvarchar(120) NULL,
    [deletedDate] datetime2 NULL,
    [Name] nvarchar(max) NULL,
    [NormalizedName] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    CONSTRAINT [PK_Roles] PRIMARY KEY ([Id])
);

CREATE TABLE [SalaryType] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(100) NULL,
    [shortName] nvarchar(50) NULL,
    CONSTRAINT [PK_SalaryType] PRIMARY KEY ([Id])
);

CREATE TABLE [SmartModule] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NULL,
    [shortName] nvarchar(150) NULL,
    [isActive] bit NOT NULL,
    CONSTRAINT [PK_SmartModule] PRIMARY KEY ([Id])
);

CREATE TABLE [Subject] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NOT NULL,
    [code] nvarchar(50) NULL,
    [reportDisplayName] nvarchar(150) NULL,
    [totalMarks] int NOT NULL,
    [reportSortingOrder] int NOT NULL,
    CONSTRAINT [PK_Subject] PRIMARY KEY ([Id])
);

CREATE TABLE [TransferType] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    CONSTRAINT [PK_TransferType] PRIMARY KEY ([Id])
);

CREATE TABLE [UserClaims] (
    [Id] int NOT NULL IDENTITY,
    [UserId] nvarchar(max) NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_UserClaims] PRIMARY KEY ([Id])
);

CREATE TABLE [UserInfo] (
    [Id] nvarchar(450) NOT NULL,
    [FirstName] nvarchar(max) NULL,
    [LastName] nvarchar(max) NULL,
    [Contact] nvarchar(max) NULL,
    [Gender] nvarchar(max) NULL,
    [DateOfBirth] datetime2 NULL,
    [ProfilePicUrl] nvarchar(max) NULL,
    [isActive] bit NULL,
    [LastLoginTime] datetime2 NULL,
    [UserType] nvarchar(50) NULL,
    [createdBy] nvarchar(120) NULL,
    [createdDate] datetime2 NULL,
    [updatedBy] nvarchar(120) NULL,
    [updatedDate] datetime2 NULL,
    [isDeleted] bit NULL,
    [deletedBy] nvarchar(120) NULL,
    [deletedDate] datetime2 NULL,
    [UserName] nvarchar(max) NULL,
    [NormalizedUserName] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    [NormalizedEmail] nvarchar(max) NULL,
    [EmailConfirmed] bit NOT NULL,
    [PasswordHash] nvarchar(max) NULL,
    [SecurityStamp] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    [PhoneNumber] nvarchar(max) NULL,
    [PhoneNumberConfirmed] bit NOT NULL,
    [TwoFactorEnabled] bit NOT NULL,
    [LockoutEnd] datetimeoffset NULL,
    [LockoutEnabled] bit NOT NULL,
    [AccessFailedCount] int NOT NULL,
    CONSTRAINT [PK_UserInfo] PRIMARY KEY ([Id])
);

CREATE TABLE [UserLogins] (
    [LoginProvider] nvarchar(450) NOT NULL,
    [ProviderKey] nvarchar(450) NOT NULL,
    [ProviderDisplayName] nvarchar(max) NULL,
    [UserId] nvarchar(max) NULL,
    CONSTRAINT [PK_UserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey])
);

CREATE TABLE [UserRoles] (
    [UserId] nvarchar(450) NOT NULL,
    [RoleId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_UserRoles] PRIMARY KEY ([UserId], [RoleId])
);

CREATE TABLE [UserTokens] (
    [UserId] nvarchar(450) NOT NULL,
    [LoginProvider] nvarchar(450) NOT NULL,
    [Name] nvarchar(450) NOT NULL,
    [Value] nvarchar(max) NULL,
    CONSTRAINT [PK_UserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name])
);

CREATE TABLE [AccademicSection] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [AccademicClassId] int NULL,
    CONSTRAINT [PK_AccademicSection] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AccademicSection_AccademicClass_AccademicClassId] FOREIGN KEY ([AccademicClassId]) REFERENCES [AccademicClass] ([Id]) ON DELETE NO ACTION
);

CREATE TABLE [Bank] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(100) NULL,
    [shortName] nvarchar(50) NULL,
    [BankTypeId] int NULL,
    [description] nvarchar(150) NULL,
    [address] nvarchar(max) NULL,
    CONSTRAINT [PK_Bank] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Bank_BankType_BankTypeId] FOREIGN KEY ([BankTypeId]) REFERENCES [BankType] ([Id]) ON DELETE NO ACTION
);

CREATE TABLE [CityCorporationCounsil] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NOT NULL,
    [counsilNo] int NULL,
    [CityCorporationId] int NULL,
    CONSTRAINT [PK_CityCorporationCounsil] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_CityCorporationCounsil_CityCorporation_CityCorporationId] FOREIGN KEY ([CityCorporationId]) REFERENCES [CityCorporation] ([Id]) ON DELETE NO ACTION
);

CREATE TABLE [Division] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(250) NOT NULL,
    [code] nvarchar(50) NULL,
    [CountryId] int NULL,
    CONSTRAINT [PK_Division] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Division_Country_CountryId] FOREIGN KEY ([CountryId]) REFERENCES [Country] ([Id]) ON DELETE NO ACTION
);

CREATE TABLE [Education] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(120) NOT NULL,
    [code] nvarchar(30) NULL,
    [ExamController] nvarchar(30) NULL,
    [SortingOrder] int NOT NULL,
    [EducationLevelId] int NULL,
    CONSTRAINT [PK_Education] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Education_EducationLevel_EducationLevelId] FOREIGN KEY ([EducationLevelId]) REFERENCES [EducationLevel] ([Id]) ON DELETE NO ACTION
);

CREATE TABLE [InstitutionalDivision] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(250) NOT NULL,
    [displayName] nvarchar(250) NULL,
    [code] nvarchar(50) NULL,
    [isMainDivision] bit NULL,
    [InstitutionId] int NULL,
    [createdBy] int NULL,
    [createdDate] datetime2 NULL,
    [updatedBy] int NULL,
    [updatedDate] datetime2 NULL,
    [deletedBy] int NULL,
    [isDeleted] bit NULL,
    [deletedDate] datetime2 NULL,
    CONSTRAINT [PK_InstitutionalDivision] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_InstitutionalDivision_Institution_InstitutionId] FOREIGN KEY ([InstitutionId]) REFERENCES [Institution] ([Id]) ON DELETE NO ACTION
);

CREATE TABLE [SmartFeature] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NULL,
    [areaName] nvarchar(150) NULL,
    [controllerName] nvarchar(250) NULL,
    [actionName] nvarchar(150) NULL,
    [FeatureCategoryId] int NULL,
    [SmartModuleId] int NULL,
    CONSTRAINT [PK_SmartFeature] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SmartFeature_FeatureCategory_FeatureCategoryId] FOREIGN KEY ([FeatureCategoryId]) REFERENCES [FeatureCategory] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_SmartFeature_SmartModule_SmartModuleId] FOREIGN KEY ([SmartModuleId]) REFERENCES [SmartModule] ([Id]) ON DELETE NO ACTION
);

CREATE TABLE [SubjectDetails] (
    [Id] int NOT NULL IDENTITY,
    [SubjectId] int NULL,
    [AccademicClassId] int NULL,
    CONSTRAINT [PK_SubjectDetails] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SubjectDetails_AccademicClass_AccademicClassId] FOREIGN KEY ([AccademicClassId]) REFERENCES [AccademicClass] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_SubjectDetails_Subject_SubjectId] FOREIGN KEY ([SubjectId]) REFERENCES [Subject] ([Id]) ON DELETE NO ACTION
);

CREATE TABLE [District] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [code] nvarchar(50) NULL,
    [DivisionId] int NULL,
    CONSTRAINT [PK_District] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_District_Division_DivisionId] FOREIGN KEY ([DivisionId]) REFERENCES [Division] ([Id]) ON DELETE NO ACTION
);

CREATE TABLE [Branch] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(250) NOT NULL,
    [code] nvarchar(50) NULL,
    [shortName] nvarchar(50) NULL,
    [contact] nvarchar(30) NULL,
    [email] nvarchar(150) NULL,
    [address] nvarchar(250) NULL,
    [isMainBranch] bit NULL,
    [reportSortingOrder] nvarchar(100) NULL,
    [InstitutionId] int NOT NULL,
    [InstitutionalDivisionId] int NOT NULL,
    [createdBy] int NULL,
    [createdDate] datetime2 NULL,
    [updatedBy] int NULL,
    [updatedDate] datetime2 NULL,
    [deletedBy] int NULL,
    [isDeleted] bit NULL,
    [deletedDate] datetime2 NULL,
    CONSTRAINT [PK_Branch] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Branch_Institution_InstitutionId] FOREIGN KEY ([InstitutionId]) REFERENCES [Institution] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Branch_InstitutionalDivision_InstitutionalDivisionId] FOREIGN KEY ([InstitutionalDivisionId]) REFERENCES [InstitutionalDivision] ([Id]) ON DELETE NO ACTION
);

CREATE TABLE [EmailConfiguration] (
    [Id] int NOT NULL IDENTITY,
    [fromName] nvarchar(250) NULL,
    [fromMail] nvarchar(250) NULL,
    [ccEmail] nvarchar(250) NULL,
    [bccEmail] nvarchar(250) NULL,
    [smtpServer] nvarchar(150) NULL,
    [serverPort] int NOT NULL,
    [hostName] nvarchar(250) NULL,
    [userName] nvarchar(250) NULL,
    [password] nvarchar(250) NULL,
    [isServerUseSsl] bit NOT NULL,
    [InstitutionalDivisionId] int NOT NULL,
    CONSTRAINT [PK_EmailConfiguration] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_EmailConfiguration_InstitutionalDivision_InstitutionalDivisionId] FOREIGN KEY ([InstitutionalDivisionId]) REFERENCES [InstitutionalDivision] ([Id]) ON DELETE NO ACTION
);

CREATE TABLE [GeneralConfiguration] (
    [Id] int NOT NULL IDENTITY,
    [purpose] nvarchar(120) NULL,
    [configLabel] nvarchar(120) NULL,
    [configName] nvarchar(120) NULL,
    [configOptions] nvarchar(50) NULL,
    [configValue] nvarchar(50) NULL,
    [InstitutionalDivisionId] int NULL,
    CONSTRAINT [PK_GeneralConfiguration] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_GeneralConfiguration_InstitutionalDivision_InstitutionalDivisionId] FOREIGN KEY ([InstitutionalDivisionId]) REFERENCES [InstitutionalDivision] ([Id]) ON DELETE NO ACTION
);

CREATE TABLE [Holiday] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NOT NULL,
    [fromDate] datetime2 NOT NULL,
    [toDate] datetime2 NOT NULL,
    [AccademicYearId] int NOT NULL,
    [HolydayTypeId] int NULL,
    [InstitutionalDivisionId] int NULL,
    CONSTRAINT [PK_Holiday] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Holiday_AccademicYear_AccademicYearId] FOREIGN KEY ([AccademicYearId]) REFERENCES [AccademicYear] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Holiday_HolydayType_HolydayTypeId] FOREIGN KEY ([HolydayTypeId]) REFERENCES [HolydayType] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Holiday_InstitutionalDivision_InstitutionalDivisionId] FOREIGN KEY ([InstitutionalDivisionId]) REFERENCES [InstitutionalDivision] ([Id]) ON DELETE NO ACTION
);

CREATE TABLE [Thana] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NOT NULL,
    [code] nvarchar(50) NULL,
    [DistrictId] int NULL,
    CONSTRAINT [PK_Thana] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Thana_District_DistrictId] FOREIGN KEY ([DistrictId]) REFERENCES [District] ([Id]) ON DELETE NO ACTION
);

CREATE TABLE [BankBranch] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(120) NULL,
    [address] nvarchar(250) NULL,
    [isMainBranch] bit NOT NULL,
    [contact] nvarchar(30) NULL,
    [email] nvarchar(120) NULL,
    [BankId] int NOT NULL,
    [BranchId] int NULL,
    CONSTRAINT [PK_BankBranch] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_BankBranch_Bank_BankId] FOREIGN KEY ([BankId]) REFERENCES [Bank] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_BankBranch_Branch_BranchId] FOREIGN KEY ([BranchId]) REFERENCES [Branch] ([Id]) ON DELETE NO ACTION
);

CREATE TABLE [BranchIncharge] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NULL,
    [code] nvarchar(50) NULL,
    [fatherName] nvarchar(150) NULL,
    [motherName] nvarchar(150) NULL,
    [contactNumber] nvarchar(30) NULL,
    [email] nvarchar(100) NULL,
    [address] nvarchar(max) NULL,
    [fromDate] datetime2 NULL,
    [toDate] datetime2 NULL,
    [BranchId] int NOT NULL,
    CONSTRAINT [PK_BranchIncharge] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_BranchIncharge_Branch_BranchId] FOREIGN KEY ([BranchId]) REFERENCES [Branch] ([Id]) ON DELETE NO ACTION
);

CREATE TABLE [Building] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NULL,
    [code] nvarchar(50) NULL,
    [buildingPosition] nvarchar(50) NULL,
    [buildingType] nvarchar(100) NULL,
    [BranchId] int NULL,
    [createdBy] int NULL,
    [createdDate] datetime2 NULL,
    [updatedBy] int NULL,
    [updatedDate] datetime2 NULL,
    [deletedBy] int NULL,
    [isDeleted] bit NULL,
    [deletedDate] datetime2 NULL,
    CONSTRAINT [PK_Building] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Building_Branch_BranchId] FOREIGN KEY ([BranchId]) REFERENCES [Branch] ([Id]) ON DELETE NO ACTION
);

CREATE TABLE [Department] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NOT NULL,
    [code] nvarchar(30) NULL,
    [shortName] nvarchar(50) NULL,
    [BranchId] int NULL,
    [createdBy] int NULL,
    [createdDate] datetime2 NULL,
    [updatedBy] int NULL,
    [updatedDate] datetime2 NULL,
    [deletedBy] int NULL,
    [isDeleted] bit NULL,
    [deletedDate] datetime2 NULL,
    CONSTRAINT [PK_Department] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Department_Branch_BranchId] FOREIGN KEY ([BranchId]) REFERENCES [Branch] ([Id]) ON DELETE NO ACTION
);

CREATE TABLE [Shift] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(120) NULL,
    [shortName] nvarchar(50) NULL,
    [fromDate] datetime2 NULL,
    [toDate] datetime2 NULL,
    [beginTime] time NULL,
    [endTime] time NULL,
    [shiftUser] nvarchar(30) NULL,
    [isActive] bit NOT NULL,
    [BranchId] int NULL,
    CONSTRAINT [PK_Shift] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Shift_Branch_BranchId] FOREIGN KEY ([BranchId]) REFERENCES [Branch] ([Id]) ON DELETE NO ACTION
);

CREATE TABLE [Municipality] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NOT NULL,
    [code] nvarchar(50) NULL,
    [address] nvarchar(150) NULL,
    [ThanaId] int NULL,
    CONSTRAINT [PK_Municipality] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Municipality_Thana_ThanaId] FOREIGN KEY ([ThanaId]) REFERENCES [Thana] ([Id]) ON DELETE NO ACTION
);

CREATE TABLE [Union] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NOT NULL,
    [code] nvarchar(50) NULL,
    [ThanaId] int NULL,
    CONSTRAINT [PK_Union] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Union_Thana_ThanaId] FOREIGN KEY ([ThanaId]) REFERENCES [Thana] ([Id]) ON DELETE NO ACTION
);

CREATE TABLE [BuildingRoom] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [floorNumber] int NULL,
    [roomNumber] nvarchar(max) NULL,
    [BuildingId] int NOT NULL,
    [createdBy] int NULL,
    [createdDate] datetime2 NULL,
    [updatedBy] int NULL,
    [updatedDate] datetime2 NULL,
    [deletedBy] int NULL,
    [isDeleted] bit NULL,
    [deletedDate] datetime2 NULL,
    CONSTRAINT [PK_BuildingRoom] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_BuildingRoom_Building_BuildingId] FOREIGN KEY ([BuildingId]) REFERENCES [Building] ([Id]) ON DELETE NO ACTION
);

CREATE TABLE [Designation] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(120) NOT NULL,
    [code] nvarchar(50) NULL,
    [shortName] nvarchar(50) NULL,
    [DepartmentId] int NULL,
    [createdBy] int NULL,
    [createdDate] datetime2 NULL,
    [updatedBy] int NULL,
    [updatedDate] datetime2 NULL,
    [deletedBy] int NULL,
    [isDeleted] bit NULL,
    [deletedDate] datetime2 NULL,
    CONSTRAINT [PK_Designation] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Designation_Department_DepartmentId] FOREIGN KEY ([DepartmentId]) REFERENCES [Department] ([Id]) ON DELETE NO ACTION
);

CREATE TABLE [Section] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(100) NOT NULL,
    [code] nvarchar(30) NULL,
    [DepartmentId] int NULL,
    CONSTRAINT [PK_Section] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Section_Department_DepartmentId] FOREIGN KEY ([DepartmentId]) REFERENCES [Department] ([Id]) ON DELETE NO ACTION
);

CREATE TABLE [MunicipalityCounsil] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NOT NULL,
    [counsilNo] int NULL,
    [MunicipalityId] int NULL,
    CONSTRAINT [PK_MunicipalityCounsil] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_MunicipalityCounsil_Municipality_MunicipalityId] FOREIGN KEY ([MunicipalityId]) REFERENCES [Municipality] ([Id]) ON DELETE NO ACTION
);

CREATE TABLE [Word] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NOT NULL,
    [wordNo] int NULL,
    [UnionId] int NULL,
    CONSTRAINT [PK_Word] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Word_Union_UnionId] FOREIGN KEY ([UnionId]) REFERENCES [Union] ([Id]) ON DELETE NO ACTION
);

CREATE TABLE [ClassRoom] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(150) NULL,
    [code] nvarchar(150) NULL,
    [BranchId] int NULL,
    [AccademicClassId] int NULL,
    [AccademicSectionId] int NULL,
    [BuildingRoomId] int NULL,
    CONSTRAINT [PK_ClassRoom] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_ClassRoom_AccademicClass_AccademicClassId] FOREIGN KEY ([AccademicClassId]) REFERENCES [AccademicClass] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_ClassRoom_AccademicSection_AccademicSectionId] FOREIGN KEY ([AccademicSectionId]) REFERENCES [AccademicSection] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_ClassRoom_Branch_BranchId] FOREIGN KEY ([BranchId]) REFERENCES [Branch] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_ClassRoom_BuildingRoom_BuildingRoomId] FOREIGN KEY ([BuildingRoomId]) REFERENCES [BuildingRoom] ([Id]) ON DELETE NO ACTION
);

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[AccademicClass]'))
    SET IDENTITY_INSERT [AccademicClass] ON;
INSERT INTO [AccademicClass] ([Id], [Name])
VALUES (1, N'One'),
(2, N'Two'),
(3, N'Three'),
(4, N'Four'),
(5, N'Five'),
(6, N'Six'),
(7, N'Seven'),
(8, N'Eight'),
(9, N'Nine'),
(10, N'Ten'),
(11, N'Eleven'),
(12, N'Twelve');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[AccademicClass]'))
    SET IDENTITY_INSERT [AccademicClass] OFF;

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[AddressType]'))
    SET IDENTITY_INSERT [AddressType] ON;
INSERT INTO [AddressType] ([Id], [Name])
VALUES (1, N'Present'),
(2, N'Permanent');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[AddressType]'))
    SET IDENTITY_INSERT [AddressType] OFF;

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[BloodGroup]'))
    SET IDENTITY_INSERT [BloodGroup] ON;
INSERT INTO [BloodGroup] ([Id], [Name])
VALUES (1, N'A+'),
(2, N'A-'),
(3, N'B+'),
(4, N'B-'),
(5, N'O+'),
(6, N'O-'),
(7, N'AB+'),
(8, N'AB-');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[BloodGroup]'))
    SET IDENTITY_INSERT [BloodGroup] OFF;

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'code', N'mobileDialingCode', N'shortName') AND [object_id] = OBJECT_ID(N'[Country]'))
    SET IDENTITY_INSERT [Country] ON;
INSERT INTO [Country] ([Id], [Name], [code], [mobileDialingCode], [shortName])
VALUES (1, N'Bangladesh', N'101', N'+880', N'BD');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'code', N'mobileDialingCode', N'shortName') AND [object_id] = OBJECT_ID(N'[Country]'))
    SET IDENTITY_INSERT [Country] OFF;

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'GroupOrFacultyType', N'Name') AND [object_id] = OBJECT_ID(N'[EducationGroupFaculty]'))
    SET IDENTITY_INSERT [EducationGroupFaculty] ON;
INSERT INTO [EducationGroupFaculty] ([Id], [GroupOrFacultyType], [Name])
VALUES (1, N'GF', N'Science'),
(2, N'GF', N'Business'),
(3, N'GF', N'Arts');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'GroupOrFacultyType', N'Name') AND [object_id] = OBJECT_ID(N'[EducationGroupFaculty]'))
    SET IDENTITY_INSERT [EducationGroupFaculty] OFF;

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'code') AND [object_id] = OBJECT_ID(N'[EducationLevel]'))
    SET IDENTITY_INSERT [EducationLevel] ON;
INSERT INTO [EducationLevel] ([Id], [Name], [code])
VALUES (1, N'Primary', N'P101'),
(2, N'Secondary', N'S201'),
(3, N'Higher Secondary', N'HS301'),
(4, N'Under-graduate', N'UG401'),
(5, N'Post-graduate', N'PG501'),
(6, N'Dimploma', N'D101'),
(7, N'Post-Graduate Dimploma', N'PGD201');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'code') AND [object_id] = OBJECT_ID(N'[EducationLevel]'))
    SET IDENTITY_INSERT [EducationLevel] OFF;

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'code') AND [object_id] = OBJECT_ID(N'[EvaluationType]'))
    SET IDENTITY_INSERT [EvaluationType] ON;
INSERT INTO [EvaluationType] ([Id], [Name], [code])
VALUES (1, N'Promotion', N'PM'),
(2, N'Demotion', N'DM'),
(3, N'Increment', N'IC'),
(4, N'Decrement', N'DR');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'code') AND [object_id] = OBJECT_ID(N'[EvaluationType]'))
    SET IDENTITY_INSERT [EvaluationType] OFF;

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'shortName') AND [object_id] = OBJECT_ID(N'[Gender]'))
    SET IDENTITY_INSERT [Gender] ON;
INSERT INTO [Gender] ([Id], [Name], [shortName])
VALUES (1, N'Male', N'M'),
(2, N'Female', N'Fe'),
(3, N'Third-Gender', N'TG');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'shortName') AND [object_id] = OBJECT_ID(N'[Gender]'))
    SET IDENTITY_INSERT [Gender] OFF;

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[HolydayType]'))
    SET IDENTITY_INSERT [HolydayType] ON;
INSERT INTO [HolydayType] ([Id], [Name])
VALUES (1, N'Govt'),
(2, N'Eid'),
(3, N'Puza'),
(4, N'Weekly'),
(5, N'Others');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[HolydayType]'))
    SET IDENTITY_INSERT [HolydayType] OFF;

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'shortName') AND [object_id] = OBJECT_ID(N'[Language]'))
    SET IDENTITY_INSERT [Language] ON;
INSERT INTO [Language] ([Id], [Name], [shortName])
VALUES (1, N'English', N'ENG'),
(2, N'Bangla', N'BAN');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'shortName') AND [object_id] = OBJECT_ID(N'[Language]'))
    SET IDENTITY_INSERT [Language] OFF;

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'code', N'isGroup') AND [object_id] = OBJECT_ID(N'[MajorGroupSubject]'))
    SET IDENTITY_INSERT [MajorGroupSubject] ON;
INSERT INTO [MajorGroupSubject] ([Id], [Name], [code], [isGroup])
VALUES (1, N'Science', N'101', CAST(1 AS bit)),
(2, N'Commerce', N'102', CAST(1 AS bit)),
(3, N'Arts', N'103', CAST(1 AS bit));
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'code', N'isGroup') AND [object_id] = OBJECT_ID(N'[MajorGroupSubject]'))
    SET IDENTITY_INSERT [MajorGroupSubject] OFF;

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'code') AND [object_id] = OBJECT_ID(N'[MaritalStatus]'))
    SET IDENTITY_INSERT [MaritalStatus] ON;
INSERT INTO [MaritalStatus] ([Id], [Name], [code])
VALUES (1, N'Married', N'101'),
(2, N'Unmarried', N'102'),
(3, N'Divorced', N'103'),
(4, N'Widowed', N'104');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'code') AND [object_id] = OBJECT_ID(N'[MaritalStatus]'))
    SET IDENTITY_INSERT [MaritalStatus] OFF;

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'code', N'createdBy', N'createdDate', N'deletedBy', N'deletedDate', N'isDeleted', N'shortName', N'updatedBy', N'updatedDate') AND [object_id] = OBJECT_ID(N'[MobileBank]'))
    SET IDENTITY_INSERT [MobileBank] ON;
INSERT INTO [MobileBank] ([Id], [Name], [code], [createdBy], [createdDate], [deletedBy], [deletedDate], [isDeleted], [shortName], [updatedBy], [updatedDate])
VALUES (1, N'Bikash', NULL, NULL, NULL, NULL, NULL, NULL, N'BK', NULL, NULL),
(2, N'Nagad', NULL, NULL, NULL, NULL, NULL, NULL, N'ND', NULL, NULL),
(3, N'Rocket', NULL, NULL, NULL, NULL, NULL, NULL, N'RKT', NULL, NULL);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'code', N'createdBy', N'createdDate', N'deletedBy', N'deletedDate', N'isDeleted', N'shortName', N'updatedBy', N'updatedDate') AND [object_id] = OBJECT_ID(N'[MobileBank]'))
    SET IDENTITY_INSERT [MobileBank] OFF;

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'code') AND [object_id] = OBJECT_ID(N'[QoutaInfo]'))
    SET IDENTITY_INSERT [QoutaInfo] ON;
INSERT INTO [QoutaInfo] ([Id], [Name], [code])
VALUES (1, N'Freedom', N'101'),
(2, N'Disable', N'102');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'code') AND [object_id] = OBJECT_ID(N'[QoutaInfo]'))
    SET IDENTITY_INSERT [QoutaInfo] OFF;

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Relation]'))
    SET IDENTITY_INSERT [Relation] ON;
INSERT INTO [Relation] ([Id], [Name])
VALUES (1, N'Father'),
(2, N'Mother'),
(3, N'Brother'),
(4, N'Sister'),
(5, N'Uncle'),
(6, N'Aunty'),
(7, N'Grand-Father'),
(8, N'Grand-Mother');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Relation]'))
    SET IDENTITY_INSERT [Relation] OFF;

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Religion]'))
    SET IDENTITY_INSERT [Religion] ON;
INSERT INTO [Religion] ([Id], [Name])
VALUES (1, N'Islam'),
(2, N'Hindu'),
(3, N'Christian'),
(4, N'Buddist');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Religion]'))
    SET IDENTITY_INSERT [Religion] OFF;

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'shortName') AND [object_id] = OBJECT_ID(N'[SalaryType]'))
    SET IDENTITY_INSERT [SalaryType] ON;
INSERT INTO [SalaryType] ([Id], [Name], [shortName])
VALUES (1, N'Consolidated', N'C'),
(2, N'Regular', N'R');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'shortName') AND [object_id] = OBJECT_ID(N'[SalaryType]'))
    SET IDENTITY_INSERT [SalaryType] OFF;

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[TransferType]'))
    SET IDENTITY_INSERT [TransferType] ON;
INSERT INTO [TransferType] ([Id], [Name])
VALUES (1, N'Branch'),
(2, N'Department'),
(3, N'Section'),
(4, N'InstitutionalDivision'),
(5, N'Institution');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[TransferType]'))
    SET IDENTITY_INSERT [TransferType] OFF;

CREATE INDEX [IX_AccademicSection_AccademicClassId] ON [AccademicSection] ([AccademicClassId]);

CREATE INDEX [IX_Bank_BankTypeId] ON [Bank] ([BankTypeId]);

CREATE INDEX [IX_BankBranch_BankId] ON [BankBranch] ([BankId]);

CREATE INDEX [IX_BankBranch_BranchId] ON [BankBranch] ([BranchId]);

CREATE INDEX [IX_Branch_InstitutionalDivisionId] ON [Branch] ([InstitutionalDivisionId]);

CREATE INDEX [IX_Branch_InstitutionId] ON [Branch] ([InstitutionId]);

CREATE INDEX [IX_BranchIncharge_BranchId] ON [BranchIncharge] ([BranchId]);

CREATE INDEX [IX_Building_BranchId] ON [Building] ([BranchId]);

CREATE INDEX [IX_BuildingRoom_BuildingId] ON [BuildingRoom] ([BuildingId]);

CREATE INDEX [IX_CityCorporationCounsil_CityCorporationId] ON [CityCorporationCounsil] ([CityCorporationId]);

CREATE INDEX [IX_ClassRoom_AccademicClassId] ON [ClassRoom] ([AccademicClassId]);

CREATE INDEX [IX_ClassRoom_AccademicSectionId] ON [ClassRoom] ([AccademicSectionId]);

CREATE INDEX [IX_ClassRoom_BranchId] ON [ClassRoom] ([BranchId]);

CREATE INDEX [IX_ClassRoom_BuildingRoomId] ON [ClassRoom] ([BuildingRoomId]);

CREATE INDEX [IX_Department_BranchId] ON [Department] ([BranchId]);

CREATE INDEX [IX_Designation_DepartmentId] ON [Designation] ([DepartmentId]);

CREATE INDEX [IX_District_DivisionId] ON [District] ([DivisionId]);

CREATE INDEX [IX_Division_CountryId] ON [Division] ([CountryId]);

CREATE INDEX [IX_Education_EducationLevelId] ON [Education] ([EducationLevelId]);

CREATE INDEX [IX_EmailConfiguration_InstitutionalDivisionId] ON [EmailConfiguration] ([InstitutionalDivisionId]);

CREATE INDEX [IX_GeneralConfiguration_InstitutionalDivisionId] ON [GeneralConfiguration] ([InstitutionalDivisionId]);

CREATE INDEX [IX_Holiday_AccademicYearId] ON [Holiday] ([AccademicYearId]);

CREATE INDEX [IX_Holiday_HolydayTypeId] ON [Holiday] ([HolydayTypeId]);

CREATE INDEX [IX_Holiday_InstitutionalDivisionId] ON [Holiday] ([InstitutionalDivisionId]);

CREATE INDEX [IX_InstitutionalDivision_InstitutionId] ON [InstitutionalDivision] ([InstitutionId]);

CREATE INDEX [IX_Municipality_ThanaId] ON [Municipality] ([ThanaId]);

CREATE INDEX [IX_MunicipalityCounsil_MunicipalityId] ON [MunicipalityCounsil] ([MunicipalityId]);

CREATE INDEX [IX_Section_DepartmentId] ON [Section] ([DepartmentId]);

CREATE INDEX [IX_Shift_BranchId] ON [Shift] ([BranchId]);

CREATE INDEX [IX_SmartFeature_FeatureCategoryId] ON [SmartFeature] ([FeatureCategoryId]);

CREATE INDEX [IX_SmartFeature_SmartModuleId] ON [SmartFeature] ([SmartModuleId]);

CREATE INDEX [IX_SubjectDetails_AccademicClassId] ON [SubjectDetails] ([AccademicClassId]);

CREATE INDEX [IX_SubjectDetails_SubjectId] ON [SubjectDetails] ([SubjectId]);

CREATE INDEX [IX_Thana_DistrictId] ON [Thana] ([DistrictId]);

CREATE INDEX [IX_Union_ThanaId] ON [Union] ([ThanaId]);

CREATE INDEX [IX_Word_UnionId] ON [Word] ([UnionId]);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20241221152543_InitialMigration', N'9.0.0');

COMMIT;
GO

