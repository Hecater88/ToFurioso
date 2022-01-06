using UnityEngine;

namespace State
{

    public class BikeStopState : MonoBehaviour, IBikeState
    {
        // Start is called before the first frame update
       private BikeController _bikeController;

       public void Handle(BikeController bikeController){
           if(!_bikeController)
           _bikeController = bikeController;

           _bikeController.CurrentSpeed = 0;
       }
    }
}
