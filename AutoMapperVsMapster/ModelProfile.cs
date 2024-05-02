using AutoMapper;
using AutoMapperVsMapster.Models;

namespace AutoMapperVsMapster
{
    public class ModelProfile : Profile
    {
        public ModelProfile()
        {
            CreateMap<Model1, Model2>(); // model1 i model 2 ye mapler

            CreateMap<Model1, Model2>().ForMember(dest => dest.FullName, opt => opt.MapFrom(x => x.FirstName + " " + x.LastName));

            CreateMap<ModelX, ModelY>();

            //verilerin durumunu kontrol edebilirsin örnek is digit. eger dogruysa mapler 
        }
    }
}
