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
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<AccessoryAgency> AccessoryAgencies { get; set; }
        public DbSet<AreaOfMedicalBoard> AreaOfMedicalBoards { get; set; }
        public KindOfBenefit KindOfBenefit { get; set; }
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
            modelBuilder.Entity<AccessoryAgency>().HasData(
               new AccessoryAgency[]
               {
                            new AccessoryAgency { Id = 1, AccessoryAgencyFullName = "УВД Брестского облисполкома", AccessoryAgencyShortName = "УВД Брест" },
                            new AccessoryAgency { Id = 2, AccessoryAgencyFullName = "УВД Витебского облисполкома", AccessoryAgencyShortName = "УВД Витебск" },
                            new AccessoryAgency { Id = 3, AccessoryAgencyFullName = "УВД Гомельского облисполкома", AccessoryAgencyShortName = "УВД Гомель" },
                            new AccessoryAgency { Id = 4, AccessoryAgencyFullName = "УВД Гродненского облисполкома", AccessoryAgencyShortName = "УВД Гродно" },
                            new AccessoryAgency { Id = 5, AccessoryAgencyFullName = "УВД Могилевского облисполкома", AccessoryAgencyShortName = "УВД Могилев" },
                            new AccessoryAgency { Id = 6, AccessoryAgencyFullName = "УВД Минского облисполкома", AccessoryAgencyShortName = "УВД Минской области" },
                            new AccessoryAgency { Id = 7, AccessoryAgencyFullName = "ГУВД Минского горисполкома", AccessoryAgencyShortName = "ГУВД Минск" },
                            new AccessoryAgency { Id = 8, AccessoryAgencyFullName = "Министерство внутренних дел Республики Беларусь", AccessoryAgencyShortName = "МВД" },
                            new AccessoryAgency { Id = 9, AccessoryAgencyFullName = "Департамент исполнения наказаний Министерства внутренних дел Республики Беларусь", AccessoryAgencyShortName = "ДИН МВД РБ" },
                            new AccessoryAgency { Id = 10, AccessoryAgencyFullName = "Департамент обеспечения оперативно-розыскной деятельности Министерства внутренних дел Республики Беларусь", AccessoryAgencyShortName = "ДООРД МВД РБ" },
                            new AccessoryAgency { Id = 11, AccessoryAgencyFullName = "Департамент финансовых расследований Комитета государственного контроля Республики Беларусь", AccessoryAgencyShortName = "ДФР КГК" },
                            new AccessoryAgency { Id = 12, AccessoryAgencyFullName = "Академия Министерства внутренних дел Республики Беларусь", AccessoryAgencyShortName = "МВД" },
               });

            modelBuilder.Entity<AreaOfMedicalBoard>().HasData(
               new AreaOfMedicalBoard[]
               {
                            new AreaOfMedicalBoard { Id = 1, AreaOfMedicalBoardName = "Брестская область" },
                            new AreaOfMedicalBoard { Id = 2, AreaOfMedicalBoardName = "Витебская область" },
                            new AreaOfMedicalBoard { Id = 3, AreaOfMedicalBoardName = "Гомельская область" },
                            new AreaOfMedicalBoard { Id = 4, AreaOfMedicalBoardName = "Гродненская область" },
                            new AreaOfMedicalBoard { Id = 5, AreaOfMedicalBoardName = "Могилевская область" },
                            new AreaOfMedicalBoard { Id = 6, AreaOfMedicalBoardName = "г. Минск и Минская область" },
               });


            modelBuilder.Entity<KindOfBenefit>().HasData(
                new KindOfBenefit[]
                {
                            new KindOfBenefit { Id = 1, KindOfBenefitName = "без экзаменов" },
                            new KindOfBenefit { Id = 2, KindOfBenefitName = "вне конкурса" }
                });


            modelBuilder.Entity<Benefit>().HasData(
                new Benefit[]
                {
                            new Benefit {
                                Id=1,
                                StreightOfBenefit = 9,
                                BenefitShortName = "победитель республиканской олимпиады (без экзаменов)",
                                BenefitFullName = "победители (дипломы I, II, III степени) третьего (областного, Минского городского) этапа" +
                                " республиканской олимпиады по учебным предметам, проведенной Министерством образования " +
                                "в учебном году, для которых данный предмет определен предметом первого профильного испытания, " +
                                "а также лица, имеющие аттестат об общем среднем образовании особого образца с награждением золотой " +
                                "или серебряной медалью или имеющие диплом о среднем специальном образовании с отличием, при наличии рекомендации" +
                                " педагогического совета учреждения образования, которое они закончили, при поступлении на педагогические специальности, " +
                                "перечень которых устанавливается Министерством образования;",
                                PercentageOfBenefit = 1.0,
                                KindOfBenefitId = 1
                            },
                            new Benefit {
                                Id=2,
                                StreightOfBenefit = 8,
                                BenefitShortName = "суворовец (без экзаменов)",
                                BenefitFullName = "выпускники учреждения образования «Минское суворовское военное училище», закончившие в год поступления данное " +
                                "учреждение с отметками 7 (семь) и выше баллов по всем предметам учебного плана и направленные в пределах плана распределения суворовцев " +
                                "для дальнейшего обучения в УВО Министерства обороны, Министерства внутренних дел, Министерства по чрезвычайным ситуациям, Государственного " +
                                "пограничного комитета, на военные факультеты УВО либо закончившие специализированные по спорту классы и направленные в пределах плана " +
                                "распределения для дальнейшего обучения по специальностям физической культуры и спорта на военные факультеты УВО;",
                                PercentageOfBenefit = 1.0,
                                KindOfBenefitId = 1
                            },
                            new Benefit {
                                Id=3,
                                StreightOfBenefit = 7,
                                BenefitShortName = "кадет (без экзаменов)",
                                BenefitFullName = "выпускники государственного учреждения образования «Специализированный лицей при Университете гражданской защиты Министерства по " +
                                "чрезвычайным ситуациям Республики Беларусь», учреждения образования «Специализированный лицей Министерства внутренних дел Республики Беларусь» и кадетских " +
                                "училищ, окончившие в год поступления данные учреждения с отметками 7 (семь) и выше баллов по всем предметам учебного плана. Зачисление названных в настоящем " +
                                "абзаце выпускников осуществляется при их поступлении в УВО Министерства по чрезвычайным ситуациям, Министерства обороны и на военные факультеты на специальности " +
                                "(направления специальностей, специализации), перечни которых устанавливаются Министерством по чрезвычайным ситуациям, Министерством обороны соответственно, а также" +
                                " при их поступлении в УВО Министерства внутренних дел, Государственного пограничного комитета, кроме специальностей (направлений специальностей, специализаций) " +
                                "для органов финансовых расследований Комитета государственного контроля, в количестве до 30 процентов от контрольных цифр приема (цифр приема);",
                                PercentageOfBenefit = 0.3,
                                KindOfBenefitId = 1
                            },
                            new Benefit {
                                Id=4,
                                StreightOfBenefit = 6,
                                BenefitShortName = "сирота (вне конкурса)",
                                BenefitFullName = "дети-сироты и дети, оставшиеся без попечения родителей, а также лица из числа детей-сирот и детей, оставшихся без попечения родителей, при поступлении " +
                                "на все специальности (направления специальностей, специализации) (кроме медицинских специальностей, а также специальностей «Международные отношения», «Международное право», " +
                                "«Правоведение», «Экономическое право», «Государственное управление и право») в количестве до 30 процентов от контрольных цифр приема;",
                                PercentageOfBenefit = 0.3,
                                KindOfBenefitId = 2
                            },
                            new Benefit {
                                Id=5,
                                StreightOfBenefit = 5,
                                BenefitShortName = "суворовец или кадет (вне конкурса)",
                                BenefitFullName = "выпускники учреждения образования «Минское суворовское военное училище», государственного учреждения образования «Специализированный лицей при " +
                                "Университете гражданской защиты Министерства по чрезвычайным ситуациям Республики Беларусь», учреждения образования «Специализированный лицей Министерства внутренних " +
                                "дел Республики Беларусь» и кадетских училищ, окончившие в год поступления данные учреждения, при поступлении в УВО Министерства по чрезвычайным ситуациям, Министерства " +
                                "обороны и на военные факультеты на специальности (направления специальностей, специализации), перечни которых устанавливаются Министерством по чрезвычайным ситуациям, " +
                                "Министерством обороны соответственно, в УВО Министерства внутренних дел, Государственного пограничного комитета, кроме специальностей (направлений специальностей, специализаций) " +
                                "для органов финансовых расследований Комитета государственного контроля, в количестве до 30 процентов от контрольных цифр приема (цифр приема);",
                                PercentageOfBenefit = 0.3,
                                KindOfBenefitId = 2
                            },
                            new Benefit {
                                Id=6,
                                StreightOfBenefit = 4,
                                BenefitShortName = "военнослужащий (вне конкурса)",
                                BenefitFullName = "лица, имеющие рекомендации воинских частей (прапорщики, солдаты и сержанты, проходящие военную службу по контракту; военнослужащие срочной военной службы, " +
                                "прослужившие не менее шести месяцев; граждане, уволенные со срочной военной службы в запас в год приема), лица рядового и младшего начальствующего состава органов внутренних дел, " +
                                "имеющие рекомендации органов внутренних дел, при поступлении в УВО Министерства обороны и на военные факультеты УВО на специальности, перечень которых утверждается Министерством обороны, " +
                                "а также в УВО Министерства внутренних дел, Министерства по чрезвычайным ситуациям, Государственного пограничного комитета в количестве до 30 процентов от контрольных цифр приема;",
                                PercentageOfBenefit = 0.3,
                                KindOfBenefitId = 2
                            },
                            new Benefit {
                                Id=7,
                                StreightOfBenefit = 3,
                                BenefitShortName = "пограничник (вне конкурса)",
                                BenefitFullName = "лица, имеющие рекомендации органов пограничной службы (прапорщики, солдаты и сержанты, проходящие военную службу по контракту в органах пограничной службы; военнослужащие " +
                                "срочной военной службы, прослужившие в органах пограничной службы не менее шести месяцев; граждане, уволенные со срочной военной службы из органов пограничной службы в запас в год приема), " +
                                "при зачислении в УВО Государственного пограничного комитета, а также в интересах органов пограничной службы при зачислении в УВО Министерства обороны и на военные факультеты УВО (кроме медицинских " +
                                "и экономических специальностей, а также специальностей «Международные отношения», «Международное право», «Правоведение», «Экономическое право», «Промышленное и гражданское строительство»), " +
                                "УВО Министерства внутренних дел, Министерства по чрезвычайным ситуациям в количестве до 30 процентов от контрольных цифр приема;",
                                PercentageOfBenefit = 0.3,
                                KindOfBenefitId = 2
                            },
                            new Benefit {
                                Id=8,
                                StreightOfBenefit = 2,
                                BenefitShortName = "рота почетного караула (вне конкурса)",
                                BenefitFullName = "лица, проходившие срочную военную службу в штатных подразделениях почетного караула Вооруженных Сил, органов пограничной службы, внутренних войск Министерства внутренних дел " +
                                "(выслужившие установленный срок военной службы по призыву и уволенные со срочной военной службы в запас в год приема или в году, предшествующем году приема), имеющие рекомендацию должностного лица, " +
                                "осуществляющего общее руководство сводной ротой почетного караула при подготовке и проведении государственных торжественных мероприятий, и поступающие для получения первого высшего образования, " +
                                "в количестве до 10 процентов от контрольных цифр приема;",
                                PercentageOfBenefit = 0.1,
                                KindOfBenefitId = 2
                            },
                            new Benefit {
                                Id=9,
                                StreightOfBenefit = 1,
                                BenefitShortName = "рота почетного караула (вне конкурса)",
                                BenefitFullName = "дети сотрудников органов внутренних дел и военнослужащих внутренних войск Министерства внутренних дел, погибших (умерших) при исполнении служебных обязанностей или ставших " +
                                "инвалидами в связи с исполнением служебных обязанностей, при поступлении в УВО Министерства внутренних дел;",
                                PercentageOfBenefit = 1,
                                KindOfBenefitId = 2
                            },


                });

            modelBuilder.Entity<CategoryOfApplicant>().HasData(
                new CategoryOfApplicant[]
                {
                            new CategoryOfApplicant { Id=1,  CategoryOfApplicantName = "Гражданская молодежь допризывного возраста" },
                            new CategoryOfApplicant { Id=2,  CategoryOfApplicantName = "Военнослужащий, демобилизованный из ВС" },
                            new CategoryOfApplicant { Id=3,  CategoryOfApplicantName = "Сотрудник органов внутренних дел" },
                });

            modelBuilder.Entity<Faculty>().HasData(
                new Faculty[]
                {
                            new Faculty { Id=1, FacultyShortName = "ФКМ",  FacultyFullName = "факультет криминальной милиции" },
                            new Faculty { Id=2, FacultyShortName = "ФМОБ",  FacultyFullName = "факультет милиции общественной безопасности" },
                            new Faculty { Id=3, FacultyShortName = "СЭФ",  FacultyFullName = "следственно-экспертный факультет" },
                            new Faculty { Id=4, FacultyShortName = "УИФ",  FacultyFullName = "уголовно-исполнительный факультет" },
                });

            modelBuilder.Entity<ForeignLanguage>().HasData(
                new ForeignLanguage[]
                {
                            new ForeignLanguage { Id=1,  ForeignLanguageShortName = "англ.", ForeignLanguageFullName = "английский язык" },
                            new ForeignLanguage { Id=2,  ForeignLanguageShortName = "нем.", ForeignLanguageFullName = "немецкий язык" },
                });

            modelBuilder.Entity<HealthGroup>().HasData(
                new HealthGroup[]
                {
                            new HealthGroup { Id=1, HealthGroupName = "2"},
                            new HealthGroup { Id=2, HealthGroupName = "3"},
                });

            modelBuilder.Entity<Inspector>().HasData(
                new Inspector[]
                {
                            new Inspector { Id=1, InspectorName = "Белянович" },
                            new Inspector { Id=2, InspectorName = "Новиков" },
                            new Inspector { Id=3, InspectorName = "Лыкова" },
                            new Inspector { Id=4, InspectorName = "Иванов" },
                            new Inspector { Id=5, InspectorName = "Петров" },
                });

            modelBuilder.Entity<KindOfEducation>().HasData(
                new KindOfEducation[]
                {
                new KindOfEducation { Id=1, KindOfAducationName = "СШ" },
                new KindOfEducation { Id=2, KindOfAducationName = "ГПТУ" },
                new KindOfEducation { Id=3, KindOfAducationName = "техникум" },
                new KindOfEducation { Id=4, KindOfAducationName = "МСВУ" },
                new KindOfEducation { Id=5, KindOfAducationName = "КУ" },
                new KindOfEducation { Id=6, KindOfAducationName = "Лицей" },
                new KindOfEducation { Id=7, KindOfAducationName = "Лицей МВД" },
                });

            modelBuilder.Entity<PFL>().HasData(
                new PFL[]
                {
                new PFL { Id=1, PFLName = "(Р1) рекомендован"},
                new PFL { Id=1, PFLName = "(Р2) ограничен"},
                new PFL { Id=1, PFLName = "(Р1) не рекомендован"},
                });


            modelBuilder.Entity<KindOfDIC>().HasData(
                new KindOfDIC[]
                {
                new KindOfDIC { Id=1, KindOfDICName = "по Брестской области"},
                new KindOfDIC { Id=2, KindOfDICName = "по Витебской области"},
                new KindOfDIC { Id=3, KindOfDICName = "по Гомельской области"},
                new KindOfDIC { Id=4, KindOfDICName = "по Гродненской области"},
                new KindOfDIC { Id=5, KindOfDICName = "по Минской области"},
                new KindOfDIC { Id=6, KindOfDICName = "по г.Минску"},
                new KindOfDIC { Id=7, KindOfDICName = "по Могилевской области"},
                });

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