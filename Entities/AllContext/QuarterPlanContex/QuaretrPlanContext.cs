using Entities.Model.All;
using Entities.Model.QuarterPlan;
using Entities.Model.User;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.AllContext.QuarterPlanContex
{
    public class QuaretrPlanContext : DatabaseConnection
    {
        public QuaretrPlanContext()
        {

        }

        public void CreateQuarterPlan(QuarterPlan quarterPlan, int loginiduser)
        {
            throw new NotImplementedException();
        }

        public void DeleteQuarterPlan(int id, int loginiduser)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<QuarterPlan> GetAllYearQuarterPlan(int year, int quarter, int queryNum)
        {
            throw new NotImplementedException();
        }

        public QuarterPlan GetQuarterPlanByID(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateQuarterPlan(int id, QuarterPlan quarterPlan, int loginiduser)
        {
            throw new NotImplementedException();
        }



        //Two


        public IEnumerable<QuarterPlanTwo> GetAllYearQuarterPlanTwo(int year, int quarter, int queryNum)
        {
            throw new NotImplementedException();
        }
        
        public QuarterPlanTwo GetQuarterPlanTwoByID(int id)
        {
            throw new NotImplementedException();
        }

        public void CreateQuarterPlanTwo(QuarterPlanTwo quarterPlan, int loginiduser)
        {
            throw new NotImplementedException();
        }

        public void DeleteQuarterPlanTwo(int id, int loginiduser)
        {
            throw new NotImplementedException();
        }
       
        public void UpdateQuarterPlanTwo(int id, QuarterPlanTwo quarterPlan, int loginiduser)
        {
            throw new NotImplementedException();
        }
    }
}
