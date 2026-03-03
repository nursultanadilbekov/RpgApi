public interface ICharacterService
{
    Task<ServiceResponse<Character>> AddCharacter(AddCharacterDto newCharacter);
    Task<ServiceResponse<List<Character>>> GetAllCharacters();
}
