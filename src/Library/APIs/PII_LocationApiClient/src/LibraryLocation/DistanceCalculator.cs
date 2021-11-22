using Ucu.Poo.Locations.Client;
/*using Nito.AsyncEx;*/


namespace Ucu.Poo.Locations.Client
{
    /*
    /// <summary>
    /// Un calculador de distancias concreto que utiliza una API de localizaci�n para calcular la distancia entre dos
    /// direcciones.
    /// </summary>
    public class DistanceCalculator : IDistanceCalculator
    {
        private LocationApiClient client;

        public DistanceCalculator(LocationApiClient client)
        {
            this.client = client;
        }

        public IDistanceResult CalculateDistance(string fromAddress, string toAddress)
        {
            // La API de localizaci�n ofrece un m�todo para obtener la distancia entre dos direcciones; aqu� se buscan
            // primero las coordenadas de las direcciones; esto permite determinar cu�l de las dos direcciones no existe.
            //
            // Los m�todos de la API de localizaci�n son async. Como el resultado de las dos primeras llamadas se utiliza
            // en la tercera, los m�todos deben ser invocados en forma sincr�nica. Por eso el uso de AsyncContext.
            Location fromLocation = AsyncContext.Run(() => client.GetLocationAsync(fromAddress));
            Location toLocation = AsyncContext.Run(() => client.GetLocationAsync(toAddress));
            Distance distance = AsyncContext.Run(() => client.GetDistanceAsync(fromLocation, toLocation));

            DistanceResult result = new DistanceResult(fromLocation, toLocation, distance.TravelDistance, distance.TravelDuration);

            return result;
        }
    }

    /// <summary>
    /// Una implementaci�n concreta del resutlado de calcular distancias. Adem�s de las propiedades definidas en
    /// IDistanceResult esta clase agrega propiedades para acceder a las coordenadas de las direcciones buscadas.
    /// </summary>
    public class DistanceResult : IDistanceResult
    {
        private Location from;
        private Location to;
        private double distance;
        private double time;

        /// <summary>
        /// Inicializa una nueva instancia de DistanceResult a partir de dos coordenadas, la distancia y el tiempo
        /// entre ellas.
        /// </summary>
        /// <param name="from">Las coordenadas de origen.</param>
        /// <param name="to">Las coordenadas de destino.</param>
        /// <param name="distance">La distancia entre las coordenadas.</param>
        /// <param name="time">El tiempo que se demora en llegar del origen al destino.</param>
        public DistanceResult(Location from, Location to, double distance, double time)
        {
            this.from = from;
            this.to = to;
            this.distance = distance;
            this.time = time;
        }

        public bool FromExists
        {
            get
            {
                return this.from.Found;
            }
        }

        public bool ToExists
        {
            get
            {
                return this.to.Found;
            }
        }

        public double Distance
        {
            get
            {
                return this.distance;
            }
        }

        public double Time
        {
            get
            {
                return this.time;
            }
        }

        public Location From
        {
            get
            {
                return this.from;
            }
        }

        public Location To
        {
            get
            {
                return this.to;
            }
        }
    }
    */
}