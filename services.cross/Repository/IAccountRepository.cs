using services.cross.Models.Results;
using services.cross.Models.ViewModels;
using System.Threading.Tasks;

namespace services.cross.Repository
{
    public interface IAccountRepository
    {
        Task<LoginResult> LoginAsync(LoginViewModel login);
        Task<SignUpResult> SignUpAsync(SignUpviewModel signUp);
    }
}
