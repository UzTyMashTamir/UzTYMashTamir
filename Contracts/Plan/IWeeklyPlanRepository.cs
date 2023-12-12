using Entities.Model.WeeklyPlanModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Plan
{
    public interface IWeeklyPlanRepository
    {
        public IEnumerable<WeeklyPlan> GetAllYearWeekluPlan(int year,int month, int week, int queryNum);

        public WeeklyPlan GetWeekluPlanByID(int id);

        public void CreateWeekluPlan(WeeklyPlan weeklyPlan, int loginiduser);

        public void UpdateWeekluPlan(int id, WeeklyPlan weeklyPlan, int loginiduser);

        public void DeleteWeekluPlan(int id, int loginiduser);
    }
}
