using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AMIAApplicant.Models
{
    public class ApplicantContext : DbContext
    {
        public ApplicantContext(DbContextOptions<ApplicantContext> options) : base(options) { }
        public DbSet<AccessoryAgency> AccessoryAgencies { get; set; }
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<AreaOfMedicalBoard> AreaOfMedicalBoards { get; set; }
        public DbSet<Benefit> Benefits { get; set; }
        public DbSet<CategoryOfApplicant> CategoryOfApplicants { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<ForeignLanguage> ForeignLanguages { get; set; }
        public DbSet<HealthGroup> HealthGroups { get; set; }
        public DbSet<Inspector> Inspectors { get; set; }
        public DbSet<KindOfEducation> KindOfEducations { get; set; }
        public DbSet<KindOfDIC> KindOfDICs { get; set; }
        public DbSet<MaritalStatus> MaritalStatuses { get; set; }
        public DbSet<MilitaryCommissariat> MilitaryCommissariats { get; set; }

        public DbSet<PFL> PFLs { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<Sex> Sexes { get; set; }
        public DbSet<TypeOfAccessoryAgency> TypeOfAccessoryAgencies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rank>().HasData(
                new Rank[]
                {
                new Rank { Id=1, RankFullName ="рядовой милиции", RankShortName = "ряд. мил."},
                new Rank { Id=2, RankFullName ="младший сержант милиции", RankShortName = "мл. с-нт мил."},
                new Rank { Id=3, RankFullName ="сержант милиции", RankShortName = "с-нт мил."},
                new Rank { Id=4, RankFullName ="старший сержант милиции", RankShortName = "ст. с-нт мил."},
                new Rank { Id=5, RankFullName ="старшина милиции", RankShortName = "с-на мил."}
                });
            modelBuilder.Entity<Sex>().HasData(
                new Sex[]
                {
                new Sex { Id=1, SexShortName="М", SexFullName = "Мужской" },
                new Sex { Id=2, SexShortName="Ж", SexFullName = "Женский" },
                });
            modelBuilder.Entity<TypeOfAccessoryAgency>().HasData(
                new TypeOfAccessoryAgency[]
                {
                    new TypeOfAccessoryAgency { Id=1, TypeOfAccessoryAgencyName = "ОВД" },
                    new TypeOfAccessoryAgency { Id=2, TypeOfAccessoryAgencyName = "ДФР" },
                    new TypeOfAccessoryAgency { Id=3, TypeOfAccessoryAgencyName = "ГПК" },
                    new TypeOfAccessoryAgency { Id=4, TypeOfAccessoryAgencyName = "МО" }
                });
            modelBuilder.Entity<MaritalStatus>().HasData(
                new MaritalStatus[]
                {
                    new MaritalStatus { Id=1, MaritalStatusName = "холост" },
                    new MaritalStatus { Id=2, MaritalStatusName = "не замужем" },
                    new MaritalStatus { Id=3, MaritalStatusName = "замужем" },
                    new MaritalStatus { Id=4, MaritalStatusName = "женат" }
                });
        }
    }
}