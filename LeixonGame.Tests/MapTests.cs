using LexiconGame2024Q3.Extensions;
using Microsoft.Extensions.Configuration;
using Moq;

namespace LeixonGame.Tests;

public class MapTests
{
    [Fact]
    public void Constructor_SetCorrectWidth_WithExtenion2()
    {
        //Arrange
        const int expectedWidth = 10;

        var iconfigMock = new Mock<IConfiguration>();
        var getMapSizeMock = new Mock<IGetMapSize>();

        getMapSizeMock.Setup(x => x.GetMapSizeFor2(iconfigMock.Object, It.IsAny<string>())).Returns(expectedWidth);
        ConfigExtension2.Implementation = getMapSizeMock.Object;
        //Act
        var map = new Map(iconfigMock.Object);

        //Assert
        Assert.Equal(expectedWidth, map.Width);
    }
    
    [Fact]
    public void Constructor_SetCorrectWidth_WithExtenion3()
    {
        //Arrange
        const int expectedWidth = 10;

        var iconfigMock = new Mock<IConfiguration>();
       
        ConfigExtension3.Implementation = (iconfig, value) => expectedWidth;
       
        //Act
        var map = new Map(iconfigMock.Object);

        //Assert
        Assert.Equal(expectedWidth, map.Width);
    }
}