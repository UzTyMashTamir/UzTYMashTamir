using Entities.Model.WeeklyPlanModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.AllContext.WeeklyPlanContex
{
    public class WeeklyPlanContext : DatabaseConnection
    {
        public WeeklyPlanContext()
        {

        }


        public void CreateWeekluPlan(WeeklyPlan weeklyPlan, int loginiduser)
        {
            throw new NotImplementedException();
        }

        public void DeleteWeekluPlan(int id, int loginiduser)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WeeklyPlan> GetAllYearWeekluPlan(int year, int month, int week, int queryNum)
        {
            throw new NotImplementedException();
        }

        public WeeklyPlan GetWeekluPlanByID(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateWeekluPlan(int id, WeeklyPlan weeklyPlan, int loginiduser)
        {
            throw new NotImplementedException();
        }
    }
}
