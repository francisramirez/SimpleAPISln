namespace CourseAdmApi.Test;
using CourseAdmApi.Controllers;
public class UnitTest1
{

   WeatherForecastController weatherForecastController = new WeatherForecastController();

  
   [Fact]
   public void GetMyName()
   {
       string name = "Francis Ramirez";
       var returnValue = this.weatherForecastController.GetMyName(name).Value;
       Assert.Equal(name,returnValue);

   }


    [Fact]
    public void Test1()
    {
          
    }
}