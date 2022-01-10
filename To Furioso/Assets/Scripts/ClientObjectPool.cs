using UnityEngine;

namespace ObjectPool
{
    public class ClientObjectPool : MonoBehaviour
    {
        private DroneObjectPool _pool;

        void Start()
        {
            _pool = gameObject.AddComponent<DroneObjectPool>();
        }

        void OnGUI()
        {
            if (GUILayout.Button("Spawn Drones"))
                _pool.Spawn();
        }
    }
}

