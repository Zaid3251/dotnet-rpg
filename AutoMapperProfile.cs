using AutoMapper;
using dotnet_rpg.Dtos.Character;

namespace dotnet_rpg
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();   
            CreateMap<AddCharacterDto,Character>();   
            CreateMap<UpdateCharacterDto,Character>();   
        }
        
    }
}