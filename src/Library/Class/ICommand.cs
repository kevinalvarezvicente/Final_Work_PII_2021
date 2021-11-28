using Telegram.Bot.Types;

namespace src.Library.Class
{
    public interface ICommand
    {
        /// <summary>
        /// Obtiene el próximo "command".
        /// La interfaz ICommand se crea para cumplir con implementación del patrón Chain Of Responsibility.
        /// </summary>
        /// <value>El "command" que será invocado si este "command" no procesa el mensaje.</value>
        /// 
        ICommand Next { get; set; }

        /// <summary>
        /// Procesa el mensaje o la pasa al siguiente "command" si existe.
        /// </summary>
        /// <param name="message">El mensaje a procesar.</param>
        /// <param name="response">La respuesta al mensaje procesado.</param>
        /// <returns>El "command" que procesó el mensaje si el mensaje fue procesado; null en caso contrario.</returns>
        ICommand Handle(Message message, out string response);

        /// <summary>
        /// Retorna este "command" al estado inicial y cancela el próximo "command" si existe. Es utilizado para que los
        /// "commands" que procesan varios mensajes cambiando de estado entre mensajes puedan volver al estado inicial en
        /// caso de error por ejemplo.
        /// </summary>
        void Cancel();
    }
}