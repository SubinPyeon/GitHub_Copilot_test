// add a namespace for the WeatherForecastController
using WebApi.Controllers;

namespace WebApiTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        // add a test method that tests the GetRange method of WeatherForecastContoller
        // create a new instance of the controller 
        var controller = new WeatherForecastController(null);
        // create a new instance of the DateRange class and set the Length property to 5
        var range = new DateRange { Length = 5 };
    }
}