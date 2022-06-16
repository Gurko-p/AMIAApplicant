using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AMIAApplicant.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccessoryAgencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccessoryAgencyFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccessoryAgencyShortName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessoryAgencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AreaOfMedicalBoards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaOfMedicalBoardName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaOfMedicalBoards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Benefits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BenefitFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BenefitShortName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PercentageOfBenefit = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benefits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryOfApplicants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryOfApplicantName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryOfApplicants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacultyFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacultyShortName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ForeignLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ForeignLanguageFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForeignLanguageShortName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForeignLanguages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HealthGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HealthGroupName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inspectors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InspectorName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspectors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KindOfDICs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KindOfDICName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KindOfDICs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KindOfEducations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KindOfAducationName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KindOfEducations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaritalStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaritalStatusName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MilitaryCommissariats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MilitaryCommissariatFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MilitaryCommissariatShortName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MilitaryCommissariatRegion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MilitaryCommissariatArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MilitaryCommissariatPostIndex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MilitaryCommissariatStreet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MilitaryCommissariatHome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MilitaryCommissariats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PFLs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PFLName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PFLs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ranks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RankFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RankShortName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ranks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sexes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SexFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SexShortName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sexes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfAccessoryAgencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfAccessoryAgencyName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfAccessoryAgencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Applicants",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Patronymic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HomeAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhichSchoolGraduated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearOfSchoolGraduated = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArrivedFromROVD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocsOriginal = table.Column<bool>(type: "bit", nullable: false),
                    FiledCertificates = table.Column<bool>(type: "bit", nullable: false),
                    Enlisted = table.Column<bool>(type: "bit", nullable: false),
                    DateOfFillingCard = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Specialities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lock = table.Column<bool>(type: "bit", nullable: false),
                    Ideas100 = table.Column<bool>(type: "bit", nullable: false),
                    Sotr = table.Column<bool>(type: "bit", nullable: false),
                    PK = table.Column<bool>(type: "bit", nullable: false),
                    MOOP = table.Column<bool>(type: "bit", nullable: false),
                    DAKTO = table.Column<bool>(type: "bit", nullable: false),
                    Reserve = table.Column<bool>(type: "bit", nullable: false),
                    GUSB = table.Column<bool>(type: "bit", nullable: false),
                    ReEmployment = table.Column<bool>(type: "bit", nullable: false),
                    AccessoryAgencyId = table.Column<int>(type: "int", nullable: false),
                    TypeOfAccessoryAgencyId = table.Column<int>(type: "int", nullable: false),
                    FacultyId = table.Column<short>(type: "smallint", nullable: true),
                    FacultyId1 = table.Column<int>(type: "int", nullable: true),
                    RankId = table.Column<int>(type: "int", nullable: false),
                    SexId = table.Column<short>(type: "smallint", nullable: false),
                    SexId1 = table.Column<int>(type: "int", nullable: true),
                    CategoryOfApplicantId = table.Column<short>(type: "smallint", nullable: false),
                    CategoryOfApplicantId1 = table.Column<int>(type: "int", nullable: true),
                    ForeignLanguageId = table.Column<short>(type: "smallint", nullable: false),
                    ForeignLanguageId1 = table.Column<int>(type: "int", nullable: true),
                    KindOfAducationId = table.Column<short>(type: "smallint", nullable: false),
                    KindOfEducationId = table.Column<int>(type: "int", nullable: true),
                    MaritalStatusId = table.Column<short>(type: "smallint", nullable: false),
                    MaritalStatusId1 = table.Column<int>(type: "int", nullable: true),
                    KindOfDICId = table.Column<short>(type: "smallint", nullable: false),
                    KindOfDICId1 = table.Column<int>(type: "int", nullable: true),
                    InspectorId = table.Column<int>(type: "int", nullable: false),
                    PFLId = table.Column<short>(type: "smallint", nullable: false),
                    PFLId1 = table.Column<int>(type: "int", nullable: true),
                    CriminalRecord = table.Column<bool>(type: "bit", nullable: false),
                    RiskGroup = table.Column<bool>(type: "bit", nullable: false),
                    FocusGroup = table.Column<bool>(type: "bit", nullable: false),
                    PsychologicalSupportGroup = table.Column<bool>(type: "bit", nullable: false),
                    HealthGroupId = table.Column<short>(type: "smallint", nullable: false),
                    HealthGroupId1 = table.Column<int>(type: "int", nullable: true),
                    AreaOfMedicalBoardId = table.Column<int>(type: "int", nullable: false),
                    MilitaryCommissariatId = table.Column<int>(type: "int", nullable: false),
                    SertificateFirst = table.Column<int>(type: "int", nullable: false),
                    SertificateSecond = table.Column<int>(type: "int", nullable: false),
                    FirstInSchoolSert = table.Column<int>(type: "int", nullable: false),
                    SecondInSchoolSert = table.Column<int>(type: "int", nullable: false),
                    SchoolCertificateSum = table.Column<int>(type: "int", nullable: false),
                    SumOfFirstAndSecond = table.Column<int>(type: "int", nullable: false),
                    BenefitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Applicants_AccessoryAgencies_AccessoryAgencyId",
                        column: x => x.AccessoryAgencyId,
                        principalTable: "AccessoryAgencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Applicants_AreaOfMedicalBoards_AreaOfMedicalBoardId",
                        column: x => x.AreaOfMedicalBoardId,
                        principalTable: "AreaOfMedicalBoards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Applicants_Benefits_BenefitId",
                        column: x => x.BenefitId,
                        principalTable: "Benefits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Applicants_CategoryOfApplicants_CategoryOfApplicantId1",
                        column: x => x.CategoryOfApplicantId1,
                        principalTable: "CategoryOfApplicants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Applicants_Faculties_FacultyId1",
                        column: x => x.FacultyId1,
                        principalTable: "Faculties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Applicants_ForeignLanguages_ForeignLanguageId1",
                        column: x => x.ForeignLanguageId1,
                        principalTable: "ForeignLanguages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Applicants_HealthGroups_HealthGroupId1",
                        column: x => x.HealthGroupId1,
                        principalTable: "HealthGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Applicants_Inspectors_InspectorId",
                        column: x => x.InspectorId,
                        principalTable: "Inspectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Applicants_KindOfDICs_KindOfDICId1",
                        column: x => x.KindOfDICId1,
                        principalTable: "KindOfDICs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Applicants_KindOfEducations_KindOfEducationId",
                        column: x => x.KindOfEducationId,
                        principalTable: "KindOfEducations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Applicants_MaritalStatuses_MaritalStatusId1",
                        column: x => x.MaritalStatusId1,
                        principalTable: "MaritalStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Applicants_MilitaryCommissariats_MilitaryCommissariatId",
                        column: x => x.MilitaryCommissariatId,
                        principalTable: "MilitaryCommissariats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Applicants_PFLs_PFLId1",
                        column: x => x.PFLId1,
                        principalTable: "PFLs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Applicants_Ranks_RankId",
                        column: x => x.RankId,
                        principalTable: "Ranks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Applicants_Sexes_SexId1",
                        column: x => x.SexId1,
                        principalTable: "Sexes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Applicants_TypeOfAccessoryAgencies_TypeOfAccessoryAgencyId",
                        column: x => x.TypeOfAccessoryAgencyId,
                        principalTable: "TypeOfAccessoryAgencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MaritalStatuses",
                columns: new[] { "Id", "MaritalStatusName" },
                values: new object[,]
                {
                    { 1, "холост" },
                    { 2, "не замужем" },
                    { 3, "замужем" },
                    { 4, "женат" }
                });

            migrationBuilder.InsertData(
                table: "Ranks",
                columns: new[] { "Id", "RankFullName", "RankShortName" },
                values: new object[,]
                {
                    { 1, "рядовой милиции", "ряд. мил." },
                    { 2, "младший сержант милиции", "мл. с-нт мил." },
                    { 3, "сержант милиции", "с-нт мил." },
                    { 4, "старший сержант милиции", "ст. с-нт мил." },
                    { 5, "старшина милиции", "с-на мил." }
                });

            migrationBuilder.InsertData(
                table: "Sexes",
                columns: new[] { "Id", "SexFullName", "SexShortName" },
                values: new object[,]
                {
                    { 1, "Мужской", "М" },
                    { 2, "Женский", "Ж" }
                });

            migrationBuilder.InsertData(
                table: "TypeOfAccessoryAgencies",
                columns: new[] { "Id", "TypeOfAccessoryAgencyName" },
                values: new object[,]
                {
                    { 1, "ОВД" },
                    { 2, "ДФР" },
                    { 3, "ГПК" },
                    { 4, "МО" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_AccessoryAgencyId",
                table: "Applicants",
                column: "AccessoryAgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_AreaOfMedicalBoardId",
                table: "Applicants",
                column: "AreaOfMedicalBoardId");

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_BenefitId",
                table: "Applicants",
                column: "BenefitId");

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_CategoryOfApplicantId1",
                table: "Applicants",
                column: "CategoryOfApplicantId1");

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_FacultyId1",
                table: "Applicants",
                column: "FacultyId1");

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_ForeignLanguageId1",
                table: "Applicants",
                column: "ForeignLanguageId1");

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_HealthGroupId1",
                table: "Applicants",
                column: "HealthGroupId1");

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_InspectorId",
                table: "Applicants",
                column: "InspectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_KindOfDICId1",
                table: "Applicants",
                column: "KindOfDICId1");

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_KindOfEducationId",
                table: "Applicants",
                column: "KindOfEducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_MaritalStatusId1",
                table: "Applicants",
                column: "MaritalStatusId1");

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_MilitaryCommissariatId",
                table: "Applicants",
                column: "MilitaryCommissariatId");

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_PFLId1",
                table: "Applicants",
                column: "PFLId1");

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_RankId",
                table: "Applicants",
                column: "RankId");

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_SexId1",
                table: "Applicants",
                column: "SexId1");

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_TypeOfAccessoryAgencyId",
                table: "Applicants",
                column: "TypeOfAccessoryAgencyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applicants");

            migrationBuilder.DropTable(
                name: "AccessoryAgencies");

            migrationBuilder.DropTable(
                name: "AreaOfMedicalBoards");

            migrationBuilder.DropTable(
                name: "Benefits");

            migrationBuilder.DropTable(
                name: "CategoryOfApplicants");

            migrationBuilder.DropTable(
                name: "Faculties");

            migrationBuilder.DropTable(
                name: "ForeignLanguages");

            migrationBuilder.DropTable(
                name: "HealthGroups");

            migrationBuilder.DropTable(
                name: "Inspectors");

            migrationBuilder.DropTable(
                name: "KindOfDICs");

            migrationBuilder.DropTable(
                name: "KindOfEducations");

            migrationBuilder.DropTable(
                name: "MaritalStatuses");

            migrationBuilder.DropTable(
                name: "MilitaryCommissariats");

            migrationBuilder.DropTable(
                name: "PFLs");

            migrationBuilder.DropTable(
                name: "Ranks");

            migrationBuilder.DropTable(
                name: "Sexes");

            migrationBuilder.DropTable(
                name: "TypeOfAccessoryAgencies");
        }
    }
}
