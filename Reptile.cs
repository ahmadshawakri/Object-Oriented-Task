namespace Oop
{
    class Reptile : Animal
    {
        public bool isColdBlooded { get; set; }
        public string? habitatType { get; set; }

        public void sunbathe()
        {
            Console.WriteLine($"{Name} is sunbathing.");
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
