namespace OOPractice
{
    public class Vehicle
    {
        public Vehicle(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }

        public string Name { get; set; }
        public int Speed { get; set; }

        public string SpeedUp()
        {
            return $"{Name} : speed up {Speed} km/h";
        }
    }
}