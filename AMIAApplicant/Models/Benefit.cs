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
        public double PercentageOfBenefit { get; set; } // Процент от выделенного количества мест по льготе
    }
}
