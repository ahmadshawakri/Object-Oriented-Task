namespace Oop
{
    class Bird : Animal
    {
        public double wingspan { get; set; }
        public bool canFly { get; set; }

        public void fly()
        {
            Console.WriteLine($"{Name} is flying");
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
