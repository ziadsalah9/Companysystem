using AutoMapper;
using Companysystem.Dtos;
using Companysystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companysystem.MapProfile
{
    public class MappingProfile :Profile
    {

        public MappingProfile()
        {
            CreateMap<Sales, SalesDto>().ForMember(d => d.Client, o => o.MapFrom(s => s.Client.Name))
                            .ForMember(d => d.Item, o => o.MapFrom(s => s.Item.Name));
        
        
        }



    }
}
