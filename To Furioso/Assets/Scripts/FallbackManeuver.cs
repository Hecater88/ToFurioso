using System.Collections;
using UnityEngine;

namespace Strategy
{
    public class FallbackManeuver : MonoBehaviour, IManeuverBehaviour
    {
        public void Maneuver(Drone1 drone)
        {
            StartCoroutine(Fallback(drone));
        }

        IEnumerator Fallback(Drone1 drone)
        {
            float time = 0;
            float speed = drone.speed;
            Vector3 startPosition = drone.transform.position;
            Vector3 endPosition = startPosition;
            endPosition.z = drone.fallbackDistance;

            while (time < speed)
            {
                drone.transform.position = Vector3.Lerp(startPosition, endPosition, time / speed);

                time += Time.deltaTime;

                yield return null;
            }
        }
    }
}

