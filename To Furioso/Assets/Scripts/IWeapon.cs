namespace Decorator
{
    //Esta es la interfaz comun entre el decorator class y el arma
    public interface IWeapon
    {
        float Rate { get; }
        float Range { get; }
        float Strength { get; }
        float Cooldown { get; }
    }
}