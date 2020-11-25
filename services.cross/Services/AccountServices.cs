using System;
using System.Threading.Tasks;
using services.cross.Models.Results;
using services.cross.Models.ViewModels;
using services.cross.Repository;

namespace services.cross.Services
{
    public class AccountServices : IAccountRepository
    {
        public Task<LoginResult> LoginAsync(LoginViewModel login)
        {
            throw new NotImplementedException();
        }

        public Task<SignUpResult> SignUpAsync(SignUpviewModel signUp)
        {
            throw new NotImplementedException();
        }
    }
}
