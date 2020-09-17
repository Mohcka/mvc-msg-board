using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace msg_board.Test
{
    public class BasicTests 
    : IClassFixture<WebApplicationFactory<msg_board.Startup>>
{
    private readonly WebApplicationFactory<msg_board.Startup> _factory;

    public BasicTests(WebApplicationFactory<msg_board.Startup> factory)
    {
        _factory = factory;
    }

    [Theory]
    [InlineData("/")]
    [InlineData("/Home/Privacy")]
    public async Task Get_EndpointsReturnSuccessAndCorrectContentType(string url)
    {
        // Arrange
        var client = _factory.CreateClient();

        // Act
        var response = await client.GetAsync(url);

        // Assert
        response.EnsureSuccessStatusCode(); // Status Code 200-299
        Assert.Equal("text/html; charset=utf-8", 
            response.Content.Headers.ContentType.ToString());
    }

    public async Task ShouldPostAndGetMessages() 
    {
        // Arrange
        var client = _factory.CreateClient();
        string expected_postMsg = "new post";
        

        // Act
        // await client.PostAsync("");

        // Assert
        Assert.Contains(expected_postMsg, "");
    }

    public async Task ShouldHaveCSRF() 
    {
        // Arrange
        var client = _factory.CreateClient();
        string expected_token = "secure-token";
        // Act

        // Assert
        Assert.Contains(expected_token, "");
    }
}
}
