using UnityEngine;

namespace Strategy
{
    public class Drone1 : MonoBehaviour
    {
        //Raycast
        private RaycastHit _hit;
        private Vector3 _rayDirection;
        private float _rayAngle = -45.0f;
        private float _rayDistance = 15.0f;

        //Movement
        public float speed = 1.0f;
        public float maxHeight = 5.0f;
        public float weavingDistance = 1.5f;
        public float fallbackDistance = 20.0f;

        // Start is called before the first frame update
        void Start()
        {
            _rayDirection = transform.TransformDirection(Vector3.back) * _rayDistance;

            _rayDirection = Quaternion.Euler(_rayAngle, 0.0f, 0f) * _rayDirection;
        }

        //Un objeto Drone puede comunicarse con las estrategias concretas que ha recibido a través de la interfaz IManeuverBehaviour. 
        //Así, sólo necesita llamar a Maneuver() para ejecutar una estrategia en tiempo de ejecución. 
        //Por lo tanto, un objeto Drone no necesita saber cómo se ejecuta el comportamiento/algoritmo de una estrategia - sólo necesita conocer su interfaz.
        public void ApplyStrategy(IManeuverBehaviour strategy)
        {
            strategy.Maneuver(this);
        }

        // Update is called once per frame
        void Update()
        {
            Debug.DrawRay(transform.position, _rayDirection, Color.blue);

            if (Physics.Raycast(transform.position, _rayDirection, out _hit, _rayDistance))
            {
                if (_hit.collider)
                {
                    Debug.DrawRay(transform.position, _rayDirection, Color.green);
                }
            }
        }
    }
}

