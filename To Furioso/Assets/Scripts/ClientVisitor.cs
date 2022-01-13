using UnityEngine;

namespace Visitor
{
    public class ClientVisitor : MonoBehaviour
    {
        public PowerUp enginePowerUp;
        public PowerUp shieldPowerUp;
        public PowerUp weaponPowerUp;

        private BikeController5 _bikeController;

        void Start()
        {
            _bikeController = gameObject.AddComponent<BikeController5>();
        }

        void OnGUI()
        {
            if (GUILayout.Button("Power Up Shield"))
                _bikeController.Accept(shieldPowerUp);

            if (GUILayout.Button("Power Up Engine"))
                _bikeController.Accept(enginePowerUp);

            if (GUILayout.Button("Power Up Weapon"))
                _bikeController.Accept(weaponPowerUp);
        }
    }
}

