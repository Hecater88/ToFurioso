
using UnityEngine;

namespace Decorator
{
    public class ClientDecorator : MonoBehaviour
    {
        private BikeWeapon1 _bikeWeapon;
        private bool _isWeaponDecorated;


        // Start is called before the first frame update
        void Start()
        {
            _bikeWeapon = (BikeWeapon1)FindObjectOfType(typeof(BikeWeapon1));
        }

        void OnGUI()
        {
            if (!_isWeaponDecorated)
                if (GUILayout.Button("Decorate Weapon"))
                {
                    _bikeWeapon.Decorate();
                    _isWeaponDecorated = !_isWeaponDecorated;
                }
                
            if (_isWeaponDecorated)
                if (GUILayout.Button("Reset Weapon"))
                {
                    _bikeWeapon.Reset();
                    _isWeaponDecorated = !_isWeaponDecorated;
                }

            if (GUILayout.Button("Toggle Fire"))
                _bikeWeapon.ToggleFire();
        }
    }

}