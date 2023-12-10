using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuberDinner.Application.Common.Interfaces.Authentication;
using BuberDinner.Application.Common.Interfaces.Persistence;
using BuberDinner.Domain;

namespace BuberDinner.Application.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUserRepository _userRepository;

        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _userRepository = userRepository;
        }

        public AuthenticationResult Register(string firstName, string lastName, string email, string password)
        {
            //Verifica se usuário não existe
            if (_userRepository.GetUserByEmail(email) is not null)
            {
                throw new Exception("E-mail já cadastrado para um usuário");
            }
            
            //Cria usuário e persiste no db
            var user = new User { FirstName = firstName, LastName = lastName, Email = email, Password = password};
            _userRepository.Add(user);
            
            //Cria token JWT
            var token = _jwtTokenGenerator.GenerateToken(user);
            
            return new AuthenticationResult(user, token);
        }

        public AuthenticationResult Login(string email, string password)
        {
            //1. Valida se usuário existe
            if (_userRepository.GetUserByEmail(email) is not User user)
            {
                throw new Exception("Não existe usuário para este e-mail");
            }
            
            //2. Valida se senha está correta
            if (user.Password != password)
            {
                throw new Exception("Senha inválida");
            }

            //3. Cria JWT Token
            var token = _jwtTokenGenerator.GenerateToken(user);

            return new AuthenticationResult(user, token);
        }
    }
}
