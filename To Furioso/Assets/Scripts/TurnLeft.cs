namespace Command
{
    public class TurnLeft : Command
    {
       private BikeController3 _controller;

       public TurnLeft (BikeController3 controller){
           _controller = controller;
       }

       public override void Execute()
       {
           _controller.Turn(BikeController3.Direction.Left);
       }
    }

}
