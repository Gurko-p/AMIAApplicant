using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AMIAApplicant.Models
{
    public class Enrollee // абитуриент
    {
        public long Id { get; set; }
        public string FirstName { get; set; } // Имя
        public string LastName { get; set; } // Фамилия
        public string Patronymic { get; set; } // Отчество

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; } // Дата рождения

        public string HomeAddress { get; set; } // Домашний адрес
        public string PersonalNumber { get; set; } // Личный номер
        public string PlaceOfBirth { get; set; } // Место рождения
        public string MotherInfo { get; set; } // Информация о матери
        public string FatherInfo { get; set; } // Информация об отце
        public string WhichSchoolGraduated { get; set; } // Какое учебное заведение окончил
        public int YearOfSchoolGraduated { get; set; } // В каком году окончил учебное заведение
        public string Note { get; set; } // Примечание
        public string ArrivedFromROVD { get; set; } // Прибыл из ГО-РОВД
        public bool DocsOriginal { get; set; } = false; // Оригинал документа об образовании
        public bool FiledCertificates { get; set; } = false; // Подал оригиналы сертификатов
        public bool Enlisted { get; set; } = false; // зачислен

        public DateTime DateOfFillingCard { get; set; } // дата заполнения карты абитуриента

        public string Specialities { get; set; } // лист специальностей

        public bool Lock { get; set; } = false; // заблокировать карточку

        public bool Ideas100 { get; set; } = false; // 100 идей для Беларуси
        public bool Sotr { get; set; } = false; // отметка и статусе "сотрудник" - преимущественное право
        public bool PK { get; set; } = false; // отметка и статусе "правовой класс" - преимущественное право
        public bool MOOP { get; set; } = false; // отметка и статусе "член МООП" - преимущественное право
        public bool DAKTO { get; set; } = false; // отметка о прохождении дактилоскопической регистрации
        public bool Reserve { get; set; } = false; // резерв
        public bool GUSB { get; set; } = false; // ГУСБ
        public bool ReEmployment { get; set; } = false; // повторный прием на службу

        public int AccessoryAgencyId { get; set; } // id комплектующий орган
        public AccessoryAgency AccessoryAgency { get; set; }

        public int TypeOfAccessoryAgencyId { get; set; } // id вид комплектующего органа
        public TypeOfAccessoryAgency TypeOfAccessoryAgency { get; set; } // МО, ОВД, ДФР

        public short? FacultyId { get; set; } // id факультета
        public Faculty Faculty { get; set; }

        public int RankId { get; set; } // id звания
        public Rank Rank { get; set; }

        public short SexId { get; set; } // id пола
        public Sex Sex { get; set; }

        public short CategoryOfApplicantId { get; set; } // id категории абитуриента
        public CategoryOfApplicant CategoryOfApplicant { get; set; }

        public short ForeignLanguageId { get; set; } // id иностранного языка, изучаемого абитуриентом
        public ForeignLanguage ForeignLanguage { get; set; }

        public short KindOfAducationId { get; set; } // id вида образования
        public KindOfAducation KindOfAducation { get; set; }

        public short MaritalStatusId { get; set; } // id семейного положения
        public MaritalStatus MaritalStatus { get; set; }

        public short KindOfDICId { get; set; } // ))))) id вида УСК
        public KindOfDIC KindOfDIC { get; set; }

        public int InspectorId { get; set; } // id инспектора ОК, заполнявшего карточку
        public Inspector Inspector { get; set; }


        public short PFLId { get; set; } // id ПФЛ
        public PFL PFL { get; set; }

        public bool CriminalRecord { get; set; } // судимость
        public bool RiskGroup { get; set; } // группа риска
        public bool FocusGroup { get; set; } // группа повышенного внимания
        public bool PsychologicalSupportGroup { get; set; } // группа психологического сопровождения

        public short HealthGroupId { get; set; } // id группы здоровья
        public HealthGroup HealthGroup { get; set; }

        public int AreaOfMedicalBoardId { get; set; } // id области медкомиссии
        public AreaOfMedicalBoard AreaOfMedicalBoard { get; set; }

        public int MilitaryCommissariatId { get; set; } // id военного комиссариата
        public MilitaryCommissariat MilitaryCommissariat { get; set; }

        public int SertificateFirst { get; set; } // балл ЦТ по первому профильному испытанию 
        public int SertificateSecond { get; set; } // балл ЦТ по второму профильному испытанию 
        public int FirstInSchoolSert { get; set; } // балл в аттестате по первому профильному испытанию 
        public int SecondInSchoolSert { get; set; } // балл в аттестате по второму профильному испытанию 
        public int SchoolCertificateSum { get; set; } // средний балл аттестата
        public int SumOfFirstAndSecond { get; set; } // сумма первого и второго профильного предмета в аттестате

        public int BenefitId { get; set; } = 0; // id льготы
        public Benefit Benefit { get; set; }
    }
}
