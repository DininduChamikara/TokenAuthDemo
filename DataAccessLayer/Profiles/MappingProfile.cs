﻿using AutoMapper;
using DataAccessLayer.DTOs;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CustomerDTO, Customer>()
            .ForMember(dest => dest.Id, opt => opt.Ignore()) // Ignore Id since it's usually auto-generated
            .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src._id)); // Map _id to CustomerId
            CreateMap<AddressDTO, Address>();
        }
    }
}
