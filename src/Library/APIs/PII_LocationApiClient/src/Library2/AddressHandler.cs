using Telegram.Bot.Types;
using PII_Proyecto_Final_TEMP.src.Library.Class;

namespace Ucu.Poo.Locations.Client
{
    /// <summary>
    /// Un "handler" del patr�n Chain of Responsibility que implementa el comando "direcci�n".
    /// </summary>
    public class AddressHandler : BaseCommand
    {
        /// <summary>
        /// El estado del comando.
        /// </summary>
        public AddressState State { get; set; }

        /// <summary>
        /// Los datos que va obteniendo el comando en los diferentes estados.
        /// </summary>
        public AddressData Data { get; set; } = new AddressData();

        // Un buscador de direcciones. Permite que la forma de encontrar una direcci�n se determine en tiempo de
        // ejecuci�n: en el c�digo final se asigna un objeto que use una API para buscar direcciones; y en los casos de
        // prueba se asigne un objeto que retorne un resultado que puede ser configurado desde el caso de prueba.
        private IAddressFinder finder;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="AddressHandler"/>.
        /// </summary>
        /// <param name="next">Un buscador de direcciones.</param>
        /// <param name="next">El pr�ximo "handler".</param>
        public AddressHandler(IAddressFinder finder, BaseCommand next)
            : base(new string[] { "direcci�n", "direccion" }, next)
        {
            this.finder = finder;
            this.State = AddressState.Start;
        }

        /// <summary>
        /// Procesa todos los mensajes y retorna true siempre.
        /// </summary>
        /// <param name="message">El mensaje a procesar.</param>
        /// <param name="response">La respuesta al mensaje procesado indicando que el mensaje no pudo se procesado.</param>
        /// <returns>true si el mensaje fue procesado; false en caso contrario.</returns>
        protected override bool InternalHandle(Message message, out string response)
        {
            if ((State == AddressState.Start) && this.CanHandle(message))
            {
                // En el estado Start le pide la direcci�n y pasa al estado AddressPrompt
                this.State = AddressState.AddressPrompt;
                response = "Vamos a buscar una direcci�n. Decime qu� direcci�n quer�s buscar por favor";
                return true;
            }
            else if ((State == AddressState.AddressPrompt) && (this.finder != null))
            {
                // En el estado AddressPrompt el mensaje recibido es la respuesta con la direcci�n
                this.Data.Address = message.Text;

                this.Data.Result = this.finder.GetLocation(this.Data.Address);

                if (this.Data.Result.Found)
                {
                    // Si encuentra la direcci�n pasa nuevamente al estado Initial
                    response = $"La direcci�n es en {Data.Result.Latitude},{Data.Result.Longitude}";
                    this.State = AddressState.Start;
                }
                else
                {
                    // Si no encuentra la direcci�n se la pide de nuevo y queda en el estado AddressPrompt
                    response = "No encuentro la direcci�n. Decime qu� direcci�n quer�s buscar por favor";
                }

                return true;
            }
            else if ((State == AddressState.AddressPrompt) && (this.finder == null))
            {
                // En el estado AddressPrompt si o hay un buscador de direcciones hay que responder que hubo un error
                // y volver al estado inicial.
                response = "Error interno de configuraci�n, no puedo buscar direcciones";
                this.State = AddressState.Start;

                return true;
            }
            else
            {
                response = string.Empty;
                return false;
            }
        }

        /// <summary>
        /// Retorna este "handler" al estado inicial.
        /// </summary>
        protected override void InternalCancel()
        {
            this.State = AddressState.Start;
            this.Data = new AddressData();
        }

        /// <summary>
        /// Indica los diferentes estados que puede tener el comando AddressHandler.
        /// - Start: El estado inicial del comando. En este estado el comando pide una direcci�n de origen y pasa al
        /// siguiente estado.
        /// - AddressPrompt: Luego de pedir la direcci�n. En este estado el comando obtiene las coordenadas de la
        /// direcci�n y vuelve al estado Start.
        /// </summary>
        public enum AddressState
        {
            Start,
            AddressPrompt
        }

        /// <summary>
        /// Representa los datos que va obteniendo el comando AddressHandler en los diferentes estados.
        /// </summary>
        public class AddressData
        {
            /// <summary>
            /// La direcci�n que se ingres� en el estado AddressState.AddressPrompt.
            /// </summary>
            public string Address { get; set; }

            /// <summary>
            /// El resultado de la b�squeda de la direcci�n ingresada.
            /// </summary>
            public IAddressResult Result { get; set; }
        }
    }
}