using UnityEngine;

namespace Observer
{
    //Las clases que deseen convertirse en observadores tienen que heredar de esta clase.
    //y utilizar el método abstracto Notify que recibe el sujeto como parámetro
    public class Observer : MonoBehaviour
    {
        public abstract void Notify(Subject subject);
    }
}

