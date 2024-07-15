using AutoMapper;
using BusinessLogic.DTOs;
using DataAccess.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Profiles
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<ProductDto, Product>()
                .ForMember(x => x.Category, opt => opt.Ignore()) 
                .ForMember(x => x.Gender, opt => opt.Ignore()) 
                .ForMember(x => x.Brand, opt => opt.Ignore()) 
                .ReverseMap();

            CreateMap<CreateProductModel, Product>()
                .ReverseMap();

            CreateMap<CategoryDto, Category>()
                .ReverseMap();

            CreateMap<GenderDto, Gender>()
                .ReverseMap();

            CreateMap<BrandDto, Brand>()
                .ReverseMap();
        }
    }
}
