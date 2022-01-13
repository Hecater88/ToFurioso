using UnityEngine;

namespace Observer
{
    public class ClientObserver : MonoBehaviour
    {
        private BikeController4 _bikeController;

        // Start is called before the first frame update
        void Start()
        {
            _bikeController = (BikeController4)FindObjectOfType(typeof(BikeController4));
        }

        // Update is called once per frame
        void OnGUI()
        {
            if (GUILayout.Button("Damage Bike"))
                if (_bikeController)
                    _bikeController.TakeDamage(15.0f);

            if (GUILayout.Button("Toggle Turbo"))
                if (_bikeController)
                    _bikeController.ToggleTurbo();
        }
    }

}
