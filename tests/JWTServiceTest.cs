using Xunit;
using LibraryManagement.Services;

public class JWTServiceTest
{
    private readonly JWTService jwtService = new();

    [Fact]
    public void GenerateToken()
    {
        string token = jwtService.GenerateToken("test");
        Assert.NotNull(token);
    }
}