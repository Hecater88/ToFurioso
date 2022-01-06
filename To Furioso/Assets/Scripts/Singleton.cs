using UnityEngine;

namespace Singleton
{
    public class Singleton<T> :
        MonoBehaviour where T : Component
    {
        private static T _instance;

        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    //Buscamos si existe alguna instancia de este objeto
                    _instance = FindObjectOfType<T>();
                    //Si no encontramos una
                    if (_instance == null)
                    {
                        //Creamos un nuevo objeto
                        GameObject obj = new GameObject();
                        obj.name = typeof(T).Name;
                        _instance = obj.AddComponent<T>();
                    }
                }
                return _instance;
            }
        }

        //marcamos el método como virtual, para así poder ser sobreescrito por alguna clase derivada. 
        //el metodo Awake() solo es llamado por primera vez cuando es inicializado en escena.
        public virtual void Awake()
        {
            //Si este objeto existe en memoria
            if (_instance == null)
            {
                //se convertirá en la instancia actual
                _instance = this as T;
                //hacemos que la instancia no se destruya entre escenas
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                //sino la destruimos, asegurandonos que solo PUEDE EXISTIR 1 CLASE
                Destroy(gameObject);
                 Debug.Log("Destruido gameobject");
            }
        }
    }

}