using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Interfaces;
using API.Models;
using AutoMapper;

namespace API.Mapping
{
    public class MetricsMappingProfiles : Profile
    {
        public MetricsMappingProfiles()
        {
            CreateMap<IMetrics, MetricsModel>().ReverseMap();
        }
    }
}
