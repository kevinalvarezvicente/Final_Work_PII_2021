using Ucu.Poo.Locations.Client;
/*
namespace Ucu.Poo.Locations.Client
{
    /// <summary>
    /// Un buscador de direcciones concreto que usa una API de localizacion.
    /// </summary>
    public class AddressFinder : IAddressFinder
    {
        private LocationApiClient client;

        /// <summary>
        /// Inicializa una nueva instancia de AddressFinder.
        /// </summary>
        /// <param name="client">El cliente de la API de localizacion.</param>
        public AddressFinder(LocationApiClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Determina si existe una direccion.
        /// </summary>
        /// <param name="address">La direccion a buscar.</param>
        /// <returns>Una instancia de AddressResult con el resultado de la busqueda, que incluye si la direccion se
        /// encontro o no, y si se encontro, la latitud y la longitud de la direccion.</returns>
        public IAddressResult GetLocation(string address)
        {
            Location location = AsyncContext.Run(() => client.GetLocationAsync(address));
            AddressResult result = new AddressResult(location);

            return result;
        }
    }

    /// <summary>
    /// Una implementacion concreta del resultado de buscar una direccion. Ademas de las propiedades definidas en
    /// IAddressResult esta clase agrega una propiedad Location para acceder a las coordenadas de la direccion buscada.
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
*/