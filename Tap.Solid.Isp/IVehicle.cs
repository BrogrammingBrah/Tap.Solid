namespace Tap.Solid.Isp
{
    internal interface ISteeringVehicle
    {
        public void MoveForward();
        public void MoveBackwards();
       
    }

    internal interface IMovingVehicle
    {
        public void MoveForward();
        public void MoveBackwards();
    }
}
