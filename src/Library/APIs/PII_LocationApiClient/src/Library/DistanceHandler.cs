using Telegram.Bot.Types;
using PII_Proyecto_Final_TEMP.src.Library.Class;

namespace Ucu.Poo.Locations.Client
{
    /// <summary>
    /// Un "handler" del patr�n Chain of Responsibility que implementa el comando "distancia".
    /// </summary>
    public class DistanceHandler : BaseCommand
    {
        /// <summary>
        /// El estado del comando.
        /// </summary>
        public DistanceState State { get; private set; }

        /// <summary>
        /// Los datos que va obteniendo el comando en los diferentes estados.
        /// </summary>
        public DistanceData Data { get; private set; } = new DistanceData();

        // Un calculador de distancias entre dos direcciones. Permite que la forma de calcular distancias se determine en
        // tiempo de ejecuci�n: en el c�digo final se asigna un objeto que use una API para buscar distancias; y en los
        // casos de prueba se asigne un objeto que retorne un resultado que puede ser configurado desde el caso de prueba.
        private IDistanceCalculator calculator;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="DistanceHandler"/>.
        /// </summary>
        /// <param name="calculator">Un calculador de distancias.</param>
        /// <param name="next">El pr�ximo "handler".</param>
        public DistanceHandler(IDistanceCalculator calculator, DistanceHandler next)
            : base(new string[] { "distancia" }, next)
        {
            this.calculator = calculator;
            this.State = DistanceState.Start;
        }

        /// <summary>
        /// Procesa todos los mensajes y retorna true siempre.
        /// </summary>
        /// <param name="message">El mensaje a procesar.</param>
        /// <param name="response">La respuesta al mensaje procesado indicando que el mensaje no pudo se procesado.</param>
        /// <returns>true si el mensaje fue procesado; false en caso contrario.</returns>
        protected override bool InternalHandle(Message message, out string response)
        {
            if ((State == DistanceState.Start) && this.CanHandle(message))
            {
                // En el estado Start le pide la direcci�n de origen y pasa al estado FromAddressPrompt
                this.State = DistanceState.FromAddressPrompt;
                response = "Vamos a calcular una distancia. Decime la direcci�n de origen por favor";
                return true;
            }
            else if ((State == DistanceState.FromAddressPrompt) && (this.calculator != null))
            {
                // En el estado FromAddressPrompt el mensaje recibido es la respuesta con la direcci�n de origen
                this.Data.FromAddress = message.Text;
                this.State = DistanceState.ToAddressPrompt;
                response = "Ahora decime la direcci�n de destino por favor";
                return true;
            }
            else if ((State == DistanceState.ToAddressPrompt) && (this.calculator != null))
            {
                this.Data.ToAddress = message.Text;
                this.Data.Result = this.calculator.CalculateDistance(this.Data.FromAddress, this.Data.ToAddress);

                if (this.Data.Result.FromExists && this.Data.Result.ToExists)
                {
                    // Si encuentra ambas direcciones retorna la distancia y pasa nuevamente al estado Start
                    response = $"La distancia es {this.Data.Result.Distance} KM";
                    this.State = DistanceState.Start;
                }
                else
                {
                    // Si no encuentra alguna de las direcciones se las pide de nuevo y vuelve al estado FromAddressPrompt.
                    // Una versi�n m�s sofisticada podr�a determinar cu�l de las dos direcciones no existe y volver al
                    // estado en el que se pide la direcci�n que falta.
                    response = "No encuentro alguna de las direcciones. Decime la direcci�n de origen por favor";
                    this.State = DistanceState.FromAddressPrompt;
                }

                return true;
            }
            else if (((State == DistanceState.FromAddressPrompt) || (State == DistanceState.FromAddressPrompt))
                && (this.calculator == null))
            {
                // En los estados FromAddressPrompt o ToAddressPrompt si no hay un buscador de direcciones hay que
                // responder que hubo un error y volver al estado inicial.
                response = "Error interno de configuraci�n, no puedo calcular distancias";
                this.State = DistanceState.Start;

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
            this.State = DistanceState.Start;
            this.Data = new DistanceData();
        }

        /// <summary>
        /// Indica los diferentes estados que puede tener el comando DistanceHandler.
        /// - Start: El estado inicial del comando. En este estado el comando pide la direcci�n de origen y pasa al
        /// siguiente estado.
        /// - FromAddressPrompt: Luego de pedir la direcci�n de origen. En este estado el comando pide la direcci�n de
        /// destino y pasa al siguiente estado.
        /// - ToAddressPrompt: Luego de pedir la direcci�n de destino. En este estado el comando calcula la distancia
        /// y vuelve al estado Start.
        /// </summary>
        public enum DistanceState
        {
            Start,
            FromAddressPrompt,
            ToAddressPrompt
        }

        /// <summary>
        /// Representa los datos que va obteniendo el comando DistanceHandler en los diferentes estados.
        /// </summary>
        public class DistanceData
        {
            /// <summary>
            /// La direcci�n que se ingres� en el estado DistanceState.FromAddressPrompt.
            /// </summary>
            public string FromAddress { get; set; }

            /// <summary>
            /// La direcci�n que se ingres� en el estado DistanceState.ToAddressPrompt.
            /// </summary>
            public string ToAddress { get; set; }

            /// <summary>
            /// El resultado del c�lculo de la distancia entre las direcciones ingresadas.
            /// </summary>
            public IDistanceResult Result { get; set; }
        }
    }
}