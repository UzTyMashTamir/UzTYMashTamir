using Entities.Model.DaylyPlanModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Plan
{
    public interface IDaylyPlanRepository
    {
        public IEnumerable<DaylyPlan> GetAllYearDaylyPlan(DateTime day_date, int queryNum);

        public DaylyPlan GetDaylyPlanByID(int id);

        public void CreateDaylyPlan(DaylyPlan daylyPlan, int loginiduser);

        public void UpdateDaylyPlan(int id, DaylyPlan daylyPlan, int loginiduser);

        public void DeleteDaylyPlan(int id, int loginiduser);
    }
}
