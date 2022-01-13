using UnityEngine;

namespace Observer
{
    public class HUDController2 : Observer
    {
        private bool _isTurboOn;
        private float _currentHealth;
        private BikeController4 _bikeController;

        void OnGUI()
        {
            GUILayout.BeginArea(
                new Rect(50, 50, 100, 200)
            );

            GUILayout.BeginHorizontal("box");
            GUILayout.Label("Health: " + _currentHealth);
            GUILayout.EndHorizontal();

            if (_isTurboOn)
            {
                GUILayout.BeginHorizontal("box");
                GUILayout.Label("Turbo Activated!");
                GUILayout.EndHorizontal();
            }

            if (_currentHealth <= 50.0f)
            {
                GUILayout.BeginHorizontal("box");
                GUILayout.Label("Warning: Low Health");
                GUILayout.EndHorizontal();
            }

            GUILayout.EndArea();
        }

        //Este método recibe la referencia del sujeto que lo notificó, puede acceder a sus propiedades y elegir cuál mostras en la interfaz
        public override void Notify(Subject subject)
        {
            if (!_bikeController)
                _bikeController = subject.GetComponent<BikeController4>();

            if (_bikeController)
            {
                _isTurboOn = _bikeController.IsTurboOn;
                _currentHealth = _bikeController.CurrentHealth;
            }
        }
    }

}
