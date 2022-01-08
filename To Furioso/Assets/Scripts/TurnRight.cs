namespace Command
{
    public class TurnRight : Command
    {
       private BikeController3 _controller;

       public TurnRight (BikeController3 controller){
           _controller = controller;
       }

       public override void Execute()
       {
           _controller.Turn(BikeController3.Direction.Right);
       }
    }

}
