namespace State
{
    public interface IBikeState
    {
        //Estamos pasando una instancia de la clase BikeController en el metodo Handle
        //Esto permite que la clase state tenga un acceso publico a las propiedades de BikeController
        void Handle(BikeController controller);
    }
}