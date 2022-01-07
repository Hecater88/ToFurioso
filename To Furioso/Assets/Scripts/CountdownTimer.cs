using System.Collections;
using UnityEngine;

namespace EventBus
{
    public class CountdownTimer : MonoBehaviour
    {
        private float _currentTime;
        private float duration = 3.0f;

        void OnEnable(){
            //Esto se activará cuando esta clase esté habilitada
            //Cada vez que se publica el evento COUNTDOWN, se llamará el metodo StarTimer
            RaceEventBus.Subscribe(RaceEventType.COUNTDOWN, StartTimer);
        }

         void OnDisable(){
            //Esto se desactivará cuando esta clase esté deshabilitada
            RaceEventBus.Unsubscribe(RaceEventType.COUNTDOWN, StartTimer);
        }

        private void StartTimer(){
            StartCoroutine(Countdown());
        }

        private IEnumerator Countdown(){
            _currentTime = duration;

            while (_currentTime >0){
                yield return new WaitForSeconds(1f);
                _currentTime--;
            }
            RaceEventBus.Publish(RaceEventType.START);
        }

        void OnGUI(){
            GUI.color =Color.blue;
            GUI.Label(
                new Rect(125, 0, 100, 20), "COUNTDOWN: " + _currentTime);
        }
    }
}

