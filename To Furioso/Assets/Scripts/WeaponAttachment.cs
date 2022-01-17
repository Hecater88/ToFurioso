using UnityEngine;

namespace Decorator
{

    [CreateAssetMenu(fileName = "NewWeaponAttachment", menuName = "Weapon/Attachment", order = 1)]
    public class WeaponAttachment : ScriptableObject, IWeapon
    {
        [Range(0, 50)]
        [Tooltip("Incrase rate of firing per second")]
        [SerializeField] public float rate;

        [Range(0, 50)]
        [Tooltip("Incrase weapon range")]
        [SerializeField] float range;

        [Range(0, 100)]
        [Tooltip("Incrase weapon stength")]
        [SerializeField] public float strength;


        [Range(0, -5)]
        [Tooltip("Reduce cooldown duration")]
        [SerializeField] public float cooldown;

        public float Rate
        {
            get { return rate; }
        }
        public float Range
        {
            get { return range; }
        }
        public float Strength
        {
            get { return strength; }
        }
        public float Cooldown
        {
            get { return cooldown; }
        }

    }

}
