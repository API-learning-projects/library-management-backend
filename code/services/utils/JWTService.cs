using JWT.Builder;
using JWT.Exceptions;
using Microsoft.AspNetCore.Http;

namespace LibraryManagement.Services
{
    public class JWTService
    {        
        public string GenerateToken(string username)
        {
            return JwtBuilder.Create()
                .WithSecret("secret")
                .AddClaim("exp", DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds())
                .AddClaim("username", username)
                .Encode();
        }

        public string GetUsernameFromToken(string token)
        {
            try {
                return JwtBuilder.Create()
                    .WithSecret("secret")
                    .MustVerifySignature()
                    .Decode<string>(token);
            } catch (TokenExpiredException) {
                throw new BadHttpRequestException("Token expired");
            } catch {
                throw new BadHttpRequestException("Invalid token");
            }
        }
    }
}