﻿using AutoMapper;
using BanVeMayBay.DataTransferObjects;
using BanVeMayBay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BanVeMayBay
{
    public static class MapsConfig
    {
        public static void Register()
        {
            Mapper.CreateMap<Base, BaseDto>()
                .Include<Airport, AirportDto>()
                .Include<Airroute, AirrouteDto>();
            Mapper.CreateMap<Airport, AirportDto>()
                .ForMember(d => d.Airroutes, s => s.MapFrom(d => d.Airroutes));
            Mapper.CreateMap<Airroute, AirrouteDto>()
                .ForSourceMember(s => s.FromAirport, d => d.Ignore())
                .ForSourceMember(s => s.ToAirport, d => d.Ignore());
        }
        public static T To<T>(this object source)
        {
            return Mapper.Map<T>(source);
        }
        public static IEnumerable<T> To<T>(this IEnumerable<object> source)
        {
            return Mapper.Map<IEnumerable<T>>(source);
        }
    }
}