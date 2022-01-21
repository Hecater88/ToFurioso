using System;
using System.Collections.Generic;

namespace ServiceLocator
{
    public static class ServiceLocator
    {
        //Gestiona un registro de servicios en forma de Diccionario, una lista de servicios disponibles
        //Solo lectura y privado, para protegerlo de cobreescritura o acceso directo.
        private static readonly IDictionary<Type, object> Services = new Dictionary<Type, Object>();

        //permite a un objeto poder ser registrado como servicio
        public static void RegisterServices<T>(T service)
        {
            if (!Services.ContainsKey(typeof(T)))
            {
                Services[typeof(T)] = service;
            }
            else
            {
                throw new ApplicationException("Service already registered");
            }
        }

        //devuelve una instancia de servicio de un tipo especifico
        public static T GetServices<T>()
        {
            try
            {
                return (T)Services[typeof(T)];
            }
            catch
            {
                throw new ApplicationException("Requested service not found");
            }
        }
    }

}
