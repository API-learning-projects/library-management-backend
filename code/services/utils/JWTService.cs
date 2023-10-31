using JWT.Builder;
using JWT.Exceptions;
using Microsoft.AspNetCore.Http;

namespace LibraryManagement.Services
{
    public class JWTService
    {        
        public string GenerateToken(int id)
        {
            return JwtBuilder.Create()
                .WithSecret("secret")
                .AddClaim("exp", DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds())
                .AddClaim("id", id)
                .Encode();
        }

        public int GetIdFromToken(string token)
        {
            try {
                return JwtBuilder.Create()
                    .WithSecret("secret")
                    .MustVerifySignature()
                    .Decode<int>(token);
            } catch (TokenExpiredException) {
                throw new BadHttpRequestException("Token expired");
            } catch {
                throw new BadHttpRequestException("Invalid token");
            }
        }
    }
}