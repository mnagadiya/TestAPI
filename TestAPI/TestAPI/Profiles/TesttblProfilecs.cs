using AutoMapper;
using TestAPI.Models.Domain;

namespace TestAPI.Profiles
{
    public class TesttblProfilecs: Profile
    {
        public TesttblProfilecs()
        {
            CreateMap<Testtbl, Models.DTO.Testtbl>()
               //.ForMember(dest => dest.Id, options => options.MapFrom(src => src.TestId))
               .ReverseMap();
        }
    }
}
