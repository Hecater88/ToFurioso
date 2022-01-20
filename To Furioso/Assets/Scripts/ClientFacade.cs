using UnityEngine;

namespace Facade
{
    public class ClientFacade : MonoBehaviour
    {
        private BikeEngine1 _bikeEngine;

        // Start is called before the first frame update
        void Start()
        {
            _bikeEngine = gameObject.AddComponent<BikeEngine1>();
        }

        void OnGUI()
        {
            if (GUILayout.Button("Turn On"))
                _bikeEngine.TurnOn();

            if (GUILayout.Button("Turn off"))
                _bikeEngine.TurnOff();

            if (GUILayout.Button("Toggle Turbo"))
                _bikeEngine.ToggleTurbo();
        }

    }

}
