namespace Oop
{
    interface IMovable
    {
        void MoveForward(double distance);
        void MoveBackward(double distance);
        void TurnLeft(double degrees);
        void TurnRight(double degrees);
    }
}
