using UnityEngine;

namespace Observer
{
    public class BikeController4 : Subject
    {
        public bool IsTurboOn
        {
            get; private set;
        }

        public float CurrentHealth
        {
            get { return health; }
        }

        private bool _isEngineOn;
        private HUDController2 _hudController;
        private CameraController _cameraController;

        [SerializeField]
        private float health = 100.0f;

        void Awake()
        {
            _hudController = gameObject.AddComponent<HUDController2>();
            _cameraController = (CameraController)FindObjectOfType(typeof(CameraController));
        }

        private void Start()
        {
            StartEngine();
        }
    }
}

