using System.Collections;
using UnityEngine;

//El turbo chage incremente la maxima velocidad del motor, se necesita que el sistema de refrigracion este desactivado
namespace Facade
{
    public class TurboCharger : MonoBehaviour
    {
        public BikeEngine1 engine;
        private bool _isTurboOn;
        private CoolingSystem _coolingSystem;

        public void ToggleTurbo(CoolingSystem coolingSystem)
        {
            _coolingSystem = coolingSystem;
            if (!_isTurboOn)
                StartCoroutine(TurboCharge());
        }

        IEnumerator TurboCharge()
        {
            _isTurboOn = true;
            _coolingSystem.PauseCooling();

            yield return new WaitForSeconds(engine.turboDuration);

            _isTurboOn = false;
            _coolingSystem.PauseCooling();
        }

        void OnGUI()
        {
            GUI.color = Color.green;
            GUI.Label
            (
                new Rect(100, 60, 500, 20), "Turbo Activated: " + _isTurboOn
            );
        }
    }

}
