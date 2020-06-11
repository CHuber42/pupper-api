using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Pupper.Models;
using Pupper.Helpers;

namespace Pupper.Services
{
  public interface IUserService
  {
    User Authenticate(string username, string password);
    IEnumerable<User> GetAll();
  }

  public class UserService : IUserService
  {
    private List<User> _users = new List<User>
    {
      new User{ Id = 1, FirstName = "Test", LastName = "User", Username = "test", Password = "test" },
      new User { Id = 2 , FirstName = "Jessica", LastName = "Hvozdovich", Username = "jhvozdovich", Password = "test"}
    };

    private readonly AppSettings _appSettings;

    public UserService(IOptions<AppSettings> appSettings)
    {
      _appSettings = appSettings.Value;
    }

    public User Authenticate(string username, string password)
    {
      var user = _users.SingleOrDefault(x => x.Username == username && x.Password == password);
      if (user == null)
      {
        return null;
      }

      //generates jwt token with successful login
      var tokenHandler = new JwtSecurityTokenHandler();
      var key = Encoding.ASCII.GetBytes(this._appSettings.Secret);
      var tokenDescriptor = new SecurityTokenDescriptor
      {
        Subject = new ClaimsIdentity(new Claim[]
        {
          new Claim(ClaimTypes.Name, user.Id.ToString())
        }),
        Expires = DateTime.UtcNow.AddDays(7),
        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
      };
      var token = tokenHandler.CreateToken(tokenDescriptor);
      user.Token = tokenHandler.WriteToken(token);

      user.Password = null;
      return user;
    }

    public IEnumerable<User> GetAll()
    {
      //get all users but not all passwords
      return _users.Select(x =>
      {
        x.Password = null;
        return x;
      });
    }
  }
}
