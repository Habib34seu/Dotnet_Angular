using datingApp.Domain.Entities;

namespace datingApp.Domain.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}