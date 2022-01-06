namespace State
{
    public class BikeStateContext
    {
        //apunta el actual state, por lo tanto es consciente de cualquier cambio de estado
        public IBikeState CurrentState
        {
            get; set;
        }

        private readonly BikeController _bikeController;


        public BikeStateContext(BikeController bikeController)
        {
            _bikeController = bikeController;
        }

        //actualizamos el estado
        public void Transition()
        {
            CurrentState.Handle(_bikeController);
        }

        public void Transition(IBikeState state)
        {
            CurrentState = state;
            CurrentState.Handle(_bikeController);
        }
    }
}