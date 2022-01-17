namespace Decorator
{
    public class WeaponDecorator : IWeapon
    {
        private readonly IWeapon _decoratedWeapon;
        private readonly WeaponAttachment _attachment;

        //WeaponDecorator se envuelve con una instancia de objeto que comparte una interfaz similar
        //En este caso IWweapon
        //Nunca modifica el objeto que lo envuelve, solo decora las propiedades publicas que es la de WeaponAttachment
        public WeaponDecorator(IWeapon weapon, WeaponAttachment attachment)
        {
            _attachment = attachment;
            _decoratedWeapon = weapon;
        }
        public float Rate
        {
            get { return _decoratedWeapon.Rate + _attachment.Rate; }
        }
        public float Range
        {
            get { return _decoratedWeapon.Range + _attachment.Range; }
        }

        public float Strength
        {
            get { return _decoratedWeapon.Strength + _attachment.Strength; }
        }

        public float Cooldown
        {
            get { return _decoratedWeapon.Cooldown + _attachment.Cooldown; }
        }
    }

}

