using UnityEngine;

namespace ServiceLocator
{
    public class ClientServiceLocator : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            RegisterServices();
        }

        private void RegisterServices()
        {
            ILoggerService logger = new Logger();
            ServiceLocator.RegisterServices(logger);

            IAnalyticsService analytics = new Analytics();
            ServiceLocator.RegisterServices(analytics);

            IAdvertisement advertisement = new Advertisement();
            ServiceLocator.RegisterServices(advertisement);

        }

        void OnGUI()
        {
            GUILayout.Label("Review output in the console:");

            if (GUILayout.Button("Log Event"))
            {
                ILoggerService logger = ServiceLocator.GetServices<ILoggerService>();
                logger.Log("Hello World!");
            }
            if (GUILayout.Button("Send Analitycs"))
            {
                IAnalyticsService analytics = ServiceLocator.GetServices<IAnalyticsService>();
                analytics.SendEvent("Hello World!");
            }
            if (GUILayout.Button("Display Advertisement"))
            {
                IAdvertisement advertisement = ServiceLocator.GetServices<IAdvertisement>();
                advertisement.DisplayAd();
            }
        }

    }


}
