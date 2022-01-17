namespace Decorator
{
    //Este objeto es el ue vamos a decorar con añadidos. En los contructores pasamos una instancia de WeaponConfig.
    public class Weapon : IWeapon
    {
        public float Range
        {
            get { return _config.Range; }
        }

        public float Rate
        {
            get { return _config.Rate; }
        }
        public float Strength
        {
            get { return _config.Strength; }
        }

        public float Cooldown
        {
            get { return _config.Cooldown; }
        }

        private readonly WeaponConfig _config;

        public Weapon(WeaponConfig weaponConfig)
        {
            _config = weaponConfig;
        }
    }
}


