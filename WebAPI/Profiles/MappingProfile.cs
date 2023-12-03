﻿using AutoMapper;
using Entities.DTO.AnualyPlan;
using Entities.DTO.AnualyPlanOne;
using Entities.DTO.AnualyPlanTwo;
using Entities.DTO.QuarterPlan;
using Entities.DTO.QuarterPlanTwo;
using Entities.DTO.User;
using Entities.DTO.User.UserCrud;
using Entities.Model.All;
using Entities.Model.AnualyPlan;
using Entities.Model.QuarterPlan;
using Entities.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //                User
            CreateMap<User, UserDTO>();
            CreateMap<User, UserReadDTO>();
            CreateMap<UserCreateDTO, User>();
            CreateMap<UserUpdatedDTO, User>();



            //                AnulayPlan
            CreateMap<AnualyPlan, AnualyPlanReadDTO>();
            CreateMap<AnualyPlanCreateDTO, AnualyPlan>();
            CreateMap<AnualyPlanUpdatedDTO, AnualyPlan>();




            //                AnulayPlanOne
            CreateMap<AnualyPlan, AnualyPlanOneReadDTO>();
            CreateMap<AnualyPlanOneCreateDTO, AnualyPlan>();
            CreateMap<AnualyPlanOneUpdatedDTO, AnualyPlan>();




            //                AnulayPlanTwo
            CreateMap<AnualyPlan, AnualyPlanTwoReadDTO>();



            //                QuarterPlanOne
            CreateMap<QuarterPlan, QuarterPlanReadDTO>();
            CreateMap<QuarterPlanCreateDTO, QuarterPlan>();
            CreateMap<QuarterPlanUpdatedDTO, QuarterPlan>();

            //            QuarterPlanOneTwo
            CreateMap<QuarterPlanTwo, QuarterPlanTwoReadDTO>();
            CreateMap<QuarterPlanTwoCreateDTO, QuarterPlanTwo>();
            CreateMap<QuarterPlanTwoUpdatedDTO, QuarterPlanTwo>();
        }
       
    }
}
