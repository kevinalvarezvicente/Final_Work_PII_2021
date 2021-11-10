using System.Threading.Tasks;

namespace Ucu.Poo.Locations.Client
{
    /// <summary>
    /// Una interfaz define una abstracci�n para un buscador de direcciones gen�rico.
    /// </summary>
    /// <remarks>
    /// Esta interfaz fue creada siguiendo el principio de inversi�n de dependencias para evitar que los comandos
    /// concretos dependan de buscadores de direcciones concretos; en su lugar los comandos concretos dependen de esta
    /// abstracci�n.
    /// Entre otras cosas est permite cambiar el buscador de direcciones en tiempo de ejecuci�n, para utilizar uno en
    /// los casos de prueba que retorna resultados conocidos para direcciones conocidas, y otro en la versi�n final para
    /// buscar usando una API de localizaciones.
    /// </remarks>
    public interface IAddressFinder
    {
        /// <summary>
        /// Determina si existe una direcci�n.
        /// </summary>
        /// <param name="address">La direcci�n a buscar.</param>
        /// <returns>Un objeto de una clase que implemente la interfaz IAddressResult con el resultado de la b�squeda, que
        /// incluye si la direcci�n se encontr� o no, y si se encontr�, la latitud y la longitud de la direcci�n.</returns>
        IAddressResult GetLocation(string address);
    }

    public interface IAddressResult
    {
        /// <summary>
        /// Indica si se encontr� o no la direcci�n. En ese caso son v�lidos los dem�s valores. En caso contrario los
        /// dem�s valores son indeterminados.
        /// </summary>
        /// <value>true si se encontr� la direcci�n; false en caso contrario.</value>
        bool Found { get; }

        /// <summary>
        /// La latitud de la direcci�n.
        /// </summary>
        /// <value>El valor de la latitud en formato decimal.</value>
        double Latitude { get; }

        /// <summary>
        /// La longitud de la direcci�n.
        /// </summary>
        /// <value>El valor de la longitud en formato decimal.</value>
        double Longitude { get; }
    }
}