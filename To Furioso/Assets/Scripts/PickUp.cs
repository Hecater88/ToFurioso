using UnityEngine;
using System.Collections;

namespace Visitor
{
    public class PickUp : MonoBehaviour
    {
        public PowerUp powerup;

        void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<BikeController5>())
            {
                Debug.Log("Chocamos");
                other.GetComponent<BikeController5>().Accept(powerup);
                Destroy(gameObject);
            }
        }

    }

}
