using UnityEngine.Events;
using System.Collections.Generic;

namespace EventBus
{
    public class RaceEventBus
    {
        //Esto actua como un libro de contabilidad en el que mantenemos una lista de relaciones entre los tipos de eventos y los suscriptores
        //Al mantenerlo privado y de sólo lectura, nos adeguramos de que no pueda ser sobreescrito por otro objeto directamente.
        private static readonly IDictionary<RaceEventType, UnityEvent>
        Events = new Dictionary<RaceEventType, UnityEvent>();

        //Un cliente deberia llamar esta funcion para añadirse a si mismo como subscriptor de un evento especifico
        //Necesista dos parametros el Tipo de Evento y el método
        public static void Subscribe (RaceEventType eventType, UnityAction listener){

            UnityEvent thisEvent;

            if(Events.TryGetValue(eventType , out thisEvent)){
                thisEvent.AddListener(listener);
            }else{
                thisEvent = new UnityEvent();
                thisEvent.AddListener(listener);
                Events.Add(eventType, thisEvent);
            }
        }

        //permite a subscriber borrar sus subscripcion de un evento especifico.
        public static void Unsubscribe (RaceEventType type, UnityAction listener){
            UnityEvent thisEvent;

            if( Events.TryGetValue (type, out thisEvent)){
                thisEvent.RemoveListener(listener);
            }
        }

        //Cuando un objeto Subscriber llama a este metodo. Los métodos registrados de todos los suscriptores de un tipo de evento espicifico seran llamados al mismo tiempo.
        public static void Publish(RaceEventType type){
            UnityEvent thisEvent;

            if(Events.TryGetValue(type, out thisEvent)){
                thisEvent.Invoke();
            }
        }
    }
}
