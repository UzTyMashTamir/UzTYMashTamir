using Entities.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model.QuarterPlan
{
    public class QuarterPlanTwo
    {
        public int q_pt_id { get; set; }
        public QuarterPlan quarter_plan { get; set; }
        public int section_1 { get; set; }
        public int section_2 { get; set; }
        public int section_3 { get; set; }
        public int section_4 { get; set; }
        public DateTime information_confirmed_date { get; set; }
        public DateTime information_entered_date { get; set; }
        public DateTime information_modified_date { get; set; }
        public StatusEnum status { get; set; }
        public int data_log { get; set; }
    }
}
