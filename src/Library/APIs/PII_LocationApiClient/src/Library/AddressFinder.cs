using Ucu.Poo.Locations.Client;
using Nito.AsyncEx;
using PII_Proyecto_Final_TEMP.src.Library.Class;

namespace Ucu.Poo.Locations.Client
{
    /// <summary>
    /// Un buscador de direcciones concreto que usa una API de localizaci�n.
    /// </summary>
    public class AddressFinder : IAddressFinder
    {
        private LocationApiClient client;

        /// <summary>
        /// Inicializa una nueva instancia de AddressFinder.
        /// </summary>
        /// <param name="client">El cliente de la API de localizaci�n.</param>
        public AddressFinder(LocationApiClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Determina si existe una direcci�n.
        /// </summary>
        /// <param name="address">La direcci�n a buscar.</param>
        /// <returns>Una instancia de AddressResult con el resultado de la b�squeda, que incluye si la direcci�n se
        /// encontr� o no, y si se encontr�, la latitud y la longitud de la direcci�n.</returns>
        public IAddressResult GetLocation(string address)
        {
            Location location = AsyncContext.Run(() => client.GetLocationAsync(address));
            AddressResult result = new AddressResult(location);

            return result;
        }
    }

    /// <summary>
    /// Una implementaci�n concreta del resultado de buscar una direcci�n. Adem�s de las propiedades definidas en
    /// IAddressResult esta clase agrega una propiedad Location para acceder a las coordenadas de la direcci�n buscada.
    /// </summary>
    public class AddressResult : IAddressResult
    {
        public Location Location { get; }

        public bool Found
        {
            get
            {
                return this.Location.Found;
            }
        }

        public double Latitude
        {
            get
            {
                return this.Location.Latitude;
            }
        }

        public double Longitude
        {
            get
            {
                return this.Location.Longitude;
            }
        }

        public AddressResult(Location location)
        {
            this.Location = location;
        }
    }
}