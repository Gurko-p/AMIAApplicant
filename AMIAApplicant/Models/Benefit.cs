using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMIAApplicant.Models
{
    public class Benefit
    {
        public int Id { get; set; }
        public string BenefitFullName { get; set; }
        public string BenefitShortName { get; set; }
        public int KindOfBenefitId { get; set; }
        public KindOfBenefit KindOfBenefit { get; set; }
        public int StreightOfBenefit { get; set; }
        public double PercentageOfBenefit { get; set; } // Процент от выделенного количества мест по льготе
    }
}
