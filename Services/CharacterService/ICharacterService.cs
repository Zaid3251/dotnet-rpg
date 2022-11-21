using dotnet_rpg.Dtos.Character;

namespace dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();

        Task<ServiceResponse<GetCharacterDto>> GetCharacteById(int id);
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharater(AddCharacterDto newCharacter);
    }
}