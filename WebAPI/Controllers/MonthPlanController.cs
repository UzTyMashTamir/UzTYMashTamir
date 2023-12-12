using AutoMapper;
using Contracts.Plan;
using Entities.DTO.MonthPlan;
using Entities.DTO.MonthPlanOne;
using Entities.Model.MonthPlanModel;
using Entities.Model.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonthPlanController : ControllerBase
    {
        private readonly IMonthPlanRepository _repository;
        private readonly IMapper _mapper;
        private static int onlineIdUser = LoginUserId.loginId;
        public MonthPlanController(IMonthPlanRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("getallmonthplan")]
        public IActionResult GetMonthPlan(int year, int quarter,int month, int queryNum)
        {
            var quarterPlans = _repository.GetAllYearMonthPlan(year, quarter,month, queryNum);

            return Ok(_mapper.Map<IEnumerable<MonthPlanDTO>>(quarterPlans));
        }




        //Month

        [Authorize(Roles = "Admin")]
        [HttpPost("createmonthplanone")]
        public IActionResult CreateMonthPlanOne(MonthPlanOneCreateDTO planCreateDTO)
        {
            if (planCreateDTO == null)
            {
                return NoContent();
            }

            var monthPlanModel = _mapper.Map<MonthPlanOne>(planCreateDTO);

            _repository.CreateMonthPlanOne(monthPlanModel, onlineIdUser);

            return Created("","");
        }



        [Authorize(Roles = "Admin")]
        [HttpGet("getallmonthplanone")]
        public IActionResult GetMonthPlanOne(int year, int quarter,int month, int queryNum)
        {
            var monthPlans = _repository.GetAllYearMonthPlanOne(year, quarter,month, queryNum);

            return Ok(_mapper.Map<IEnumerable<MonthPlanOneReadDTO>>(monthPlans));
        }



        [Authorize(Roles = "Admin")]
        [HttpGet("getbyidmonthplanone/{id}")]
        public IActionResult GetMonthPlanOneById(int id)
        {
            var monthPlan = _repository.GetMonthPlanOneByID(id);

            if (monthPlan == null || monthPlan.status == StatusEnum.deleted)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<MonthPlanOneReadDTO>(monthPlan));
        }




        [Authorize(Roles = "Admin")]
        [HttpDelete("deletemonthplanone/{id}")]
        public IActionResult DeleteMonthPlanOne(int id)
        {
            var monthPlan = _repository.GetMonthPlanOneByID(id);

            if (monthPlan == null)
            {
                return NotFound();
            }

            _repository.DeleteMonthPlanOne(id, onlineIdUser);

            return Ok();

        }



        [Authorize(Roles = "Admin")]
        [HttpPut("updatemonthplanone/{id}")]
        public IActionResult UpdateMonthPlanOne(int id, MonthPlanOneUpdatedDTO planUpdatedDTO)
        {
            var monthPlancheck = _repository.GetMonthPlanOneByID(id);

            if (monthPlancheck == null)
            {
                return NotFound();
            }
            MonthPlanOne quarterPlan = _mapper.Map<MonthPlanOne>(planUpdatedDTO);
            _repository.UpdateMonthPlanOne(id, quarterPlan, onlineIdUser);
            MonthPlanOne updateMonthPlan = _repository.GetMonthPlanOneByID(id);
            return Ok(_mapper.Map<MonthPlanOneReadDTO>(updateMonthPlan));
        }
    }
}
