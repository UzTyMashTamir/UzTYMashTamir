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
            if (quarterPlan != null)
            {
                try
                {
                    quarterPlan.status = StatusEnum.active;
                    quarterPlan.locomative_name.loco_id = locomativeGetId(quarterPlan.locomative_name.name);
                    quarterPlan.locomative_name.fuel_type = (FuelType)locomativeGettypeId(quarterPlan.locomative_name.loco_id);



                    string query1 = "INSERT INTO public.quarter_plan(" +
                        "quarter_id, loco_id, locomative_number, organization_id, reprair_id, month_of_reprair, " +
                        "section_num, information_confirmed_date," +
                        "quarter, pan_year, section_0)" +
                        $"VALUES(DEFAULT,{quarterPlan.locomative_name.loco_id},'{quarterPlan.locomative_number}'," +
                        $"'{quarterPlan.organization.org_id}',{quarterPlan.month_of_reprair},{quarterPlan.section_num}," +
                        $"'{quarterPlan.information_confirmed_date}','{quarterPlan.quarter}','{quarterPlan.plan_year}'," +
                        $"'{quarterPlan.section_0}'); ";
                    quarterPlan.data_log = logWriting(loginiduser, query1);



                    string query = "INSERT INTO public.quarter_plan(" +
                        "quarter_id, loco_id, locomative_number, organization_id, reprair_id, month_of_reprair, " +
                        "section_num, information_confirmed_date, information_entered_date, " +
                        "quarter, status_id, data_log_id, plan_year, section_0)" +
                        "  VALUES(DEFAULT, @quarter_id, @loco_id, @locomative_number, @organization_id, @reprair_id," +
                        " @month_of_reprair," +
                        "@section_num, @information_confirmed_date, @information_entered_date," +
                        "@quarter, @status_id, @data_log_id, @plan_year, @section_0); ";
                    conn.Open();
                    using (NpgsqlCommand cmd = new(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@locomative_id", quarterPlan.locomative_name.loco_id);
                        var a = cmd.ExecuteNonQuery();

                    }
                }
                catch { }
                finally { conn.Close(); }
            }
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
