using UnityEngine;

namespace EventBus
{
    public class HUDController : MonoBehaviour
    {
        private bool _isDisplayOn;

        void OnEnable(){
            RaceEventBus.Subscribe(
                RaceEventType.START, DisplayHUD
            );
        }
        void OnDisable(){
            RaceEventBus.Subscribe(
                RaceEventType.START, DisplayHUD
            );
        }

        private void DisplayHUD(){
            _isDisplayOn = true;
        }

        void OnGUI(){
            if(_isDisplayOn){
                if(GUILayout.Button("Stop Race")){
                   _isDisplayOn = false;
                   RaceEventBus.Publish(RaceEventType.STOP);
                }
            }
        }
    }
}


