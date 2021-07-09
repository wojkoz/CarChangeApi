using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using CarChangeApi.Domain.Models;
using CarChangeApi.Contracts.Responses;
using CarChangeApi.Contracts.Requests;

namespace CarChangeApi.Services.impl
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;
        private readonly ILogger<AuthService> _logger;

        public AuthService(UserManager<User> userManager, IConfiguration configuration, ILogger<AuthService> logger)
        {
            _userManager = userManager;
            _configuration = configuration;
            _logger = logger;
        }

        public async Task<IdentityResult> RegisterAsync(AuthRegisterRequest authRegisterRequest)
        {
            _logger.LogInformation("RegisterAsync");

            var userExists = await _userManager.FindByEmailAsync(authRegisterRequest.Email);
            if (userExists != null)
                return null;

            var user = new User()
            {
                Email = authRegisterRequest.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = authRegisterRequest.Username,
                Id = Guid.NewGuid().ToString()
            };
            return await _userManager.CreateAsync(user, authRegisterRequest.Password);
        }

        public async Task<UserLoginResponse> LoginAsync(AuthLoginRequest authLoginRequest)
        {
            _logger.LogInformation("LoginAsync");
            var user = await _userManager.FindByEmailAsync(authLoginRequest.Email);

            var errors = await ValidateUser(user, authLoginRequest.Password);

            if (errors.Any())
            {
                return new UserLoginResponse()
                {
                    Succeded = false,
                    Errors = errors
                };
            };

            var token = await CreateToken(user);

            return new UserLoginResponse()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                TokenValidTo = token.ValidTo,
                Succeded = true
            };
        }

        private async Task<IEnumerable<IdentityError>> ValidateUser(User user, string password)
        {
            List<IdentityError> errors = new();

            if (user == null)
            {
                errors.Add(new() { Code = "-1", Description = "User with that email don't exists" });
            };

            if (!await _userManager.CheckPasswordAsync(user, password))
            {
                errors.Add(new() { Code = "-2", Description = "Password is incorrect" });
            }


            return errors;
        }

        private async Task<JwtSecurityToken> CreateToken(User user)
        {
            var userRoles = await _userManager.GetRolesAsync(user);

            var authClaims = new List<Claim>
            {
                new (JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new (ClaimValueTypes.String, user.Id)
            };
            authClaims.AddRange(
                userRoles.Select(userRole => new Claim(ClaimTypes.Role, userRole))
            );

            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

            return new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddHours(24),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
            );
        }
    }
}
