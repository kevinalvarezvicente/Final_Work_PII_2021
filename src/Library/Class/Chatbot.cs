using Telegram.Bot;
using Telegram.Bot.Types;
using UserTelgram = Telegram.Bot.Types.User;

namespace src.Library.Class
{
    /// <summary>
    /// Clase realizada con el patrón singleton
    /// Se crea una unica instancia de esta clase y en cuyo caso de que se quiera crear otro devuelve al anterior.
    /// </summary>
    public class Chatbot
    {

        /// <value>Guarda el identificador unico del bot de Telegram.</value>
        private const string TELEGRAM_BOT_TOKEN = "1979783244:AAHxt8x8kMVl5RNWCnfy9iRGvLaI9DW4tvU";

        private static Chatbot instance;
        private ITelegramBotClient bot;

        private Chatbot()
        {
            this.bot = new TelegramBotClient(TELEGRAM_BOT_TOKEN);
        }

        public ITelegramBotClient Client
        {
            get
            {
                return this.bot;
            }
        }

        private UserTelgram BotInfo
        {
            get
            {
                return this.Client.GetMeAsync().Result;
            }
        }

        public int BotId
        {
            get
            {
                return (int)this.BotInfo.Id;
            }
        }

        public string BotName
        {
            get
            {
                return this.BotInfo.FirstName;
            }
        }

        public static Chatbot Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Chatbot();
                }
                return instance;
            }
        }
    }
}