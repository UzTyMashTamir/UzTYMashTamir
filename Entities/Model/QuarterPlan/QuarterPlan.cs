using Entities.Model.All;
using Entities.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model.QuarterPlan
{
    public class QuarterPlan
    {
        public int quarter_id { get; set; }
        public LocomativeInformation locomative_name { get; set; }
        public string locomative_number { get; set; }
        public OrganizationType organization { get; set; }
        public ReprairType reprair_id { get; set; }
        public int month_of_reprair { get; set; }
        public int section_num { get; set; }
        public DateTime information_confirmed_date { get; set; }
        public DateTime information_entered_date { get; set; }
        public DateTime information_modified_date { get; set; }
        public int quarter { get; set; }
        public StatusEnum status { get; set; }
        public int data_log { get; set; }
        public DateTime plan_year { get; set; }
        public int section_0 { get; set; }
    }
}
