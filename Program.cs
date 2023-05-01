namespace Oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"---------------------------Cat Object------------------------");

            var cat = new Mammal();
            cat.Name = "Cat";
            cat.furColor = "Grey and White";
            cat.gestationPeriod = 60;
            cat.eat("Fish");
            cat.sleep();
            cat.makeSound();
            cat.MoveForward(20);
            cat.MoveBackward(20);
            cat.TurnRight(30);
            cat.TurnLeft(30);
            cat.nurse();

            Console.WriteLine($"---------------------------Owl Object------------------------");

            var owl = new Bird();
            owl.Name = "Owl";
            owl.wingspan = 4.5;
            owl.canFly = true;
            owl.eat("Mice");
            owl.sleep();
            owl.makeSound();
            owl.MoveForward(100);
            owl.MoveBackward(40);
            owl.TurnRight(10.2);
            owl.TurnLeft(20.5);
            owl.fly();

            Console.WriteLine($"---------------------------Turtle Object------------------------");

            var turtle = new Reptile();
            turtle.Name = "Turtle";
            turtle.isColdBlooded = true;
            turtle.habitatType = "River";
            turtle.eat("Seaweed");
            turtle.sleep();
            turtle.makeSound();
            turtle.MoveForward(10.4);
            turtle.MoveBackward(0.5);
            turtle.TurnRight(1.3);
            turtle.TurnLeft(3.5);
            turtle.sunbathe();
        }
    }
}
