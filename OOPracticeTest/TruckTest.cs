using OOPractice;
using Xunit;

namespace OOPracticeTest;

public class TruckTest
{
    [Fact]
    public void Should_show_message_when_speed_up_given_truck_named_big_truck_speed_10()
    {
        //given
        var truck = new Truck("Big Truck", 10);
        //when
        string message = truck.SpeedUp();
        //then
        Assert.Equal("Big Truck : speed up 10 km/h", message);
    }
}