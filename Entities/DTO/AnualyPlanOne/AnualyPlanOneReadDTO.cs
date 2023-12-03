using Entities.Model.All;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO.AnualyPlanOne
{
    public class AnualyPlanOneReadDTO
    {
        public int a_o_id { get; set; }
        public LocomativeInformation locomative_name { get; set; }
        public int sections_reprair_number { get; set; }
        public ReprairType reprair_type { get; set; }
        public DateTime information_confirmed_date { get; set; }
        public MonthPlan month_plan { get; set; }
    }
}
