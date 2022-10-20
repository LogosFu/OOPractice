using OOPractice;
using Xunit;

namespace OOPracticeTest;

public class DriverTest
{
    [Fact]
    public void Should_drive_can_drive_vehicle_and_show_message_as_speed_up_when_speed_up_given_drive()
    {
        //given
        var car = new Car("Cool Car", 30);
        var truck = new Truck("Big Truck", 10);
        var driver = new Driver();
        //when
        driver.Drive(car);
        string messageWhenDriveCar = driver.SpeedUp();
        driver.Drive(truck);
        string messageWhenDriveTruck = driver.SpeedUp();
        //then
        Assert.Equal("Cool Car : speed up 30 km/h", messageWhenDriveCar);
        Assert.Equal("Big Truck : speed up 10 km/h", messageWhenDriveTruck);
    }
}