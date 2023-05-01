namespace Oop
{
    abstract class Animal : IMovable
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Gender { get; set; }
        public double? weight { get; set; }
        public string? diet { get; set; }
        public string? habitat { get; set; }

        public void eat(string foodName)
        {
            Console.WriteLine($"{Name} is eating {foodName}");
        }

        public void sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }

        public void makeSound()
        {
            Console.WriteLine($"{Name} is making a sound.");
        }

        public virtual void MoveForward(double distance)
        {
            Console.WriteLine($"{Name} is moving forward {distance}");
        }

        public virtual void MoveBackward(double distance)
        {
            Console.WriteLine($"{Name} is moving backward {distance}");
        }

        public virtual void TurnLeft(double degrees)
        {
            Console.WriteLine($"{Name} is turning left {degrees}");
        }

        public virtual void TurnRight(double degrees)
        {
            Console.WriteLine($"{Name} is turning right {degrees}");
        }
    }
}
