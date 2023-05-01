namespace Oop
{
    class Mammal : Animal{
        public string? furColor { get; set; }
        public int gestationPeriod { get; set;}

        public void nurse(){
            Console.WriteLine($"{Name} is nursing its young.");
        }
        public override void MoveForward(double distance)
        {
            Console.WriteLine($"{Name} is moving forward {distance}");
        }

        public override void MoveBackward(double distance)
        {
            Console.WriteLine($"{Name} is moving backward {distance}");
        }

        public override void TurnLeft(double degrees)
        {
            Console.WriteLine($"{Name} is turning left {degrees}");
        }

        public override void TurnRight(double degrees)
        {
            Console.WriteLine($"{Name} is turning right {degrees}");
        }
    }
}
