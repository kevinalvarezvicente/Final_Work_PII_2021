namespace Ucu.Poo.Locations.Client
{
    /// <summary>
    /// Una interfaz que define una abstracci�n para un calculador de distancias gen�rico.
    /// </summary>
    /// <remarks>
    /// Esta interfaz fue creada siguiendo el principio de inversi�n de dependencias para evitar que los comandos
    /// concretos dependan de calculadores de distancias concretos; en su lugar los comandos concretos dependen de esta
    /// abstracci�n.
    /// Entre otras cosas est permite cambiar el calculador de distancias en tiempo de ejecuci�n, para utilizar uno en
    /// los casos de prueba que retorna resultados conocidos para direcciones conocidas, y otro en la versi�n final para
    /// buscar usando una API de localizaciones.
    /// </remarks>
    public interface IDistanceCalculator
    {
        /// <summary>
        /// Determina si existe una direcci�n.
        /// </summary>
        /// <param name="address">La direcci�n a buscar.</param>
        /// <returns>true si la direcci�n existe; false en caso contrario.</returns>
        IDistanceResult CalculateDistance(string fromAddress, string toAddress);
    }

    /// <summary>
    /// Una interfaz que define una abstracci�n para el resultado de calcular distancias.
    /// </summary>
    public interface IDistanceResult
    {
        /// <summary>
        /// Obtiene un valor que indica si la direcci�n de origen para el c�lculo de distancias existe; s�lo se puede
        /// calcular la distancia entre direcciones que existen.
        /// </summary>
        bool FromExists { get; }

        /// <summary>
        /// Obtiene un valor que indica si la direcci�n de destino para el c�lculo de distancias existe; s�lo se puede
        /// calcular la distancia entre direcciones que existen.
        /// </summary>
        bool ToExists { get; }

        /// <summary>
        /// La distancia calculada.
        /// </summary>
        double Distance { get; }

        /// <summary>
        /// El tiempo en llegar del origen al destino.
        /// </summary>
        double Time { get; }
    }
}