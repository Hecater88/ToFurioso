namespace Command
{
    public class ToggleTurbo: Command
    {
        private BikeController3 _controller;

        public ToggleTurbo(BikeController3 controller)
        {
            _controller = controller;
        }

        public override void Execute()
        {
            _controller.ToggleTurbo();
        } 
    }
}