using System.Security.Claims;
using Finist_TestTask.IdentityServer.Constants;

namespace Finist_TestTask.IdentityServer.Extensions;

public static class ClaimValueParser
{
    public static Guid GetUserId(IEnumerable<Claim> claims)
    {
        var userId = claims.FirstOrDefault(x => x.Type == UserClaims.UserId)?.Value;

        if (Guid.TryParse(userId, out var result) == false)
        {
            throw new InvalidOperationException($"У пользователя отсутствует ID");
        }

        return result;
    }
}