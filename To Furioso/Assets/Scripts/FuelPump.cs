using System.Collections;
using UnityEngine;

//Simula la combustion de gasolina, resta la cantidad de gasolina y apaga el motor se si apaga la gasolina
namespace Facade
{
    public class FuelPump : MonoBehaviour
    {
        public BikeEngine1 engine;
        public IEnumerator burnFuel;


        // Start is called before the first frame update
        void Start()
        {
            burnFuel = BurnFuel();
        }

        IEnumerator BurnFuel()
        {
            while (true)
            {
                yield return new WaitForSeconds(1);
                engine.fuelAmount -= engine.burnRate;

                if (engine.fuelAmount <= 0.0f)
                {
                    engine.TurnOff();
                    yield return 0;
                }
            }
        }

        void OnGUI()
        {
            GUI.color = Color.green;
            GUI.Label
            (
                new Rect(100, 40, 500, 20), "Fuel: " + engine.fuelAmount
            );
        }
    }

}
