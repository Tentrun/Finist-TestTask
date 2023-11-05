using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Finist_TestTask.IdentityServer.Extensions;

public static class AuthOptions
{
    #region JWT
    // издатель токена
    public const string ISSUER = "Issuer";
    // потребитель токена
    public const string AUDIENCE = "Audience"; 
    // ключ для шифрации
    private const string KEY = "SecretKey123!___assaas";   
    // Lifetime токена в часах
    public const Double TokenLifetime = 6; 
    
    public static SymmetricSecurityKey GetSymmetricSecurityKey() => 
        new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KEY));
    #endregion
}